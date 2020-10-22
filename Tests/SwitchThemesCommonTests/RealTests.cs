﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SARCExt;
using SwitchThemes.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace SwitchThemesCommonTests
{
	[TestClass]
	public class RealTests
	{
		byte[] DDS = Util.ReadData("bg.dds");

		private void CompareSarc(SARCExt.SarcData a, SARCExt.SarcData b) 
		{
			Assert.AreEqual(a.Files.Count, b.Files.Count);

			foreach (var f in a.Files)
			{
				if (!b.Files.ContainsKey(f.Key))
					throw new Exception($"{f.Key} is missing in B");

				if (!b.Files[f.Key].SequenceEqual(f.Value))
					throw new Exception($"file {f.Key} is different in B");
			}
		}

		private void ProcessSzs(string name)
		{
			SarcData src = SARC.Unpack(ManagedYaz0.Decompress(Util.ReadData($"Source/{name}.szs")));
			SarcData exp = SARC.Unpack(ManagedYaz0.Decompress(Util.ReadData($"Expected/{name}.szs")));

			string lyt = Util.Exists($"Source/{name}.json") ? Util.ReadString($"Source/{name}.json") : null;

			SzsPatcher patcher = new SzsPatcher(src, SwitchThemes.Common.DefaultTemplates.templates);
			Assert.IsTrue(patcher.PatchMainBG(DDS));

			if (lyt != null)
			{
				var l = LayoutPatch.LoadTemplate(lyt);
				patcher.PatchLayouts(l, patcher.PatchTemplate);
				patcher.PatchAnimations(l.Anims);
			}

			var final = patcher.GetFinalSarc();
			CompareSarc(final, exp);
		}

		[TestMethod]
		public void ResidentMenu() =>
			ProcessSzs("ResidentMenu");

		[TestMethod]
		public void Entrance() =>
			ProcessSzs("Entrance");

		[TestMethod]
		public void Notification() =>
			ProcessSzs("Notification");

		[TestMethod]
		public void Flaunch() =>
			ProcessSzs("Flaunch");

		[TestMethod]
		public void Set() =>
			ProcessSzs("Set");
	}
}
