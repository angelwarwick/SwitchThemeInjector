﻿namespace SwitchThemes
{
	partial class Form1
	{
		/// <summary>
		/// Variabile di progettazione necessaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Pulire le risorse in uso.
		/// </summary>
		/// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Codice generato da Progettazione Windows Form

		/// <summary>
		/// Metodo necessario per il supporto della finestra di progettazione. Non modificare
		/// il contenuto del metodo con l'editor di codice.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
			this.PatchListPage = new System.Windows.Forms.TabPage();
			this.tbPatches = new System.Windows.Forms.TextBox();
			this.ExtractPage = new System.Windows.Forms.TabPage();
			this.btnExportBntx = new MaterialSkin.Controls.MaterialRaisedButton();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.InjectPage = new System.Windows.Forms.TabPage();
			this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
			this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
			this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
			this.tbBntxFile = new System.Windows.Forms.TextBox();
			this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
			this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
			this.label1 = new System.Windows.Forms.Label();
			this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
			this.lblDetected = new MaterialSkin.Controls.MaterialLabel();
			this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
			this.materialTabControl1.SuspendLayout();
			this.PatchListPage.SuspendLayout();
			this.ExtractPage.SuspendLayout();
			this.InjectPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// materialTabControl1
			// 
			this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.materialTabControl1.Controls.Add(this.PatchListPage);
			this.materialTabControl1.Controls.Add(this.ExtractPage);
			this.materialTabControl1.Controls.Add(this.InjectPage);
			this.materialTabControl1.Depth = 0;
			this.materialTabControl1.Location = new System.Drawing.Point(-1, 152);
			this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialTabControl1.Name = "materialTabControl1";
			this.materialTabControl1.SelectedIndex = 0;
			this.materialTabControl1.Size = new System.Drawing.Size(645, 288);
			this.materialTabControl1.TabIndex = 4;
			// 
			// PatchListPage
			// 
			this.PatchListPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.PatchListPage.Controls.Add(this.tbPatches);
			this.PatchListPage.Location = new System.Drawing.Point(4, 22);
			this.PatchListPage.Name = "PatchListPage";
			this.PatchListPage.Size = new System.Drawing.Size(637, 262);
			this.PatchListPage.TabIndex = 2;
			this.PatchListPage.Text = "Patch list";
			// 
			// tbPatches
			// 
			this.tbPatches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbPatches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.tbPatches.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbPatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPatches.ForeColor = System.Drawing.Color.White;
			this.tbPatches.Location = new System.Drawing.Point(9, 0);
			this.tbPatches.Multiline = true;
			this.tbPatches.Name = "tbPatches";
			this.tbPatches.ReadOnly = true;
			this.tbPatches.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbPatches.Size = new System.Drawing.Size(628, 256);
			this.tbPatches.TabIndex = 12;
			// 
			// ExtractPage
			// 
			this.ExtractPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.ExtractPage.Controls.Add(this.btnExportBntx);
			this.ExtractPage.Controls.Add(this.materialLabel1);
			this.ExtractPage.Location = new System.Drawing.Point(4, 22);
			this.ExtractPage.Name = "ExtractPage";
			this.ExtractPage.Padding = new System.Windows.Forms.Padding(3);
			this.ExtractPage.Size = new System.Drawing.Size(637, 262);
			this.ExtractPage.TabIndex = 0;
			this.ExtractPage.Text = "Extract resources";
			// 
			// btnExportBntx
			// 
			this.btnExportBntx.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnExportBntx.AutoSize = true;
			this.btnExportBntx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnExportBntx.Depth = 0;
			this.btnExportBntx.Icon = null;
			this.btnExportBntx.Location = new System.Drawing.Point(519, 268);
			this.btnExportBntx.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnExportBntx.Name = "btnExportBntx";
			this.btnExportBntx.Primary = true;
			this.btnExportBntx.Size = new System.Drawing.Size(111, 36);
			this.btnExportBntx.TabIndex = 10;
			this.btnExportBntx.Text = "Export BNTX";
			this.btnExportBntx.UseVisualStyleBackColor = true;
			this.btnExportBntx.Visible = false;
			this.btnExportBntx.Click += new System.EventHandler(this.ExtractBntxButton);
			// 
			// materialLabel1
			// 
			this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel1.Location = new System.Drawing.Point(9, 13);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(618, 232);
			this.materialLabel1.TabIndex = 0;
			this.materialLabel1.Text = resources.GetString("materialLabel1.Text");
			// 
			// InjectPage
			// 
			this.InjectPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.InjectPage.Controls.Add(this.materialLabel3);
			this.InjectPage.Controls.Add(this.materialFlatButton1);
			this.InjectPage.Controls.Add(this.materialLabel2);
			this.InjectPage.Controls.Add(this.tbBntxFile);
			this.InjectPage.Controls.Add(this.materialRaisedButton2);
			this.InjectPage.Location = new System.Drawing.Point(4, 22);
			this.InjectPage.Name = "InjectPage";
			this.InjectPage.Padding = new System.Windows.Forms.Padding(3);
			this.InjectPage.Size = new System.Drawing.Size(637, 262);
			this.InjectPage.TabIndex = 1;
			this.InjectPage.Text = "Inject & patch";
			// 
			// materialLabel3
			// 
			this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.materialLabel3.Depth = 0;
			this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel3.Location = new System.Drawing.Point(11, 50);
			this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel3.Name = "materialLabel3";
			this.materialLabel3.Size = new System.Drawing.Size(652, 148);
			this.materialLabel3.TabIndex = 5;
			this.materialLabel3.Text = resources.GetString("materialLabel3.Text");
			// 
			// materialFlatButton1
			// 
			this.materialFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.materialFlatButton1.AutoSize = true;
			this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialFlatButton1.Depth = 0;
			this.materialFlatButton1.Icon = null;
			this.materialFlatButton1.Location = new System.Drawing.Point(601, 10);
			this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialFlatButton1.Name = "materialFlatButton1";
			this.materialFlatButton1.Primary = false;
			this.materialFlatButton1.Size = new System.Drawing.Size(32, 36);
			this.materialFlatButton1.TabIndex = 3;
			this.materialFlatButton1.Text = "...";
			this.materialFlatButton1.UseVisualStyleBackColor = true;
			this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
			// 
			// materialLabel2
			// 
			this.materialLabel2.AutoSize = true;
			this.materialLabel2.Depth = 0;
			this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel2.Location = new System.Drawing.Point(11, 18);
			this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel2.Name = "materialLabel2";
			this.materialLabel2.Size = new System.Drawing.Size(71, 19);
			this.materialLabel2.TabIndex = 2;
			this.materialLabel2.Text = "Bntx file: ";
			// 
			// tbBntxFile
			// 
			this.tbBntxFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbBntxFile.Location = new System.Drawing.Point(86, 17);
			this.tbBntxFile.Name = "tbBntxFile";
			this.tbBntxFile.Size = new System.Drawing.Size(514, 20);
			this.tbBntxFile.TabIndex = 1;
			// 
			// materialRaisedButton2
			// 
			this.materialRaisedButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.materialRaisedButton2.AutoSize = true;
			this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialRaisedButton2.Depth = 0;
			this.materialRaisedButton2.Icon = null;
			this.materialRaisedButton2.Location = new System.Drawing.Point(495, 268);
			this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialRaisedButton2.Name = "materialRaisedButton2";
			this.materialRaisedButton2.Primary = true;
			this.materialRaisedButton2.Size = new System.Drawing.Size(135, 36);
			this.materialRaisedButton2.TabIndex = 0;
			this.materialRaisedButton2.Text = "Patch and save";
			this.materialRaisedButton2.UseVisualStyleBackColor = true;
			this.materialRaisedButton2.Click += new System.EventHandler(this.PatchButtonClick);
			// 
			// materialRaisedButton3
			// 
			this.materialRaisedButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.materialRaisedButton3.AutoSize = true;
			this.materialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialRaisedButton3.Depth = 0;
			this.materialRaisedButton3.Icon = null;
			this.materialRaisedButton3.Location = new System.Drawing.Point(279, 52);
			this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialRaisedButton3.Name = "materialRaisedButton3";
			this.materialRaisedButton3.Primary = true;
			this.materialRaisedButton3.Size = new System.Drawing.Size(85, 36);
			this.materialRaisedButton3.TabIndex = 11;
			this.materialRaisedButton3.Text = "Open szs";
			this.materialRaisedButton3.UseVisualStyleBackColor = true;
			this.materialRaisedButton3.Click += new System.EventHandler(this.OpenSzsButton);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(0, 429);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Exelix @ Team Qcean";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// materialTabSelector1
			// 
			this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
			this.materialTabSelector1.Depth = 0;
			this.materialTabSelector1.Location = new System.Drawing.Point(-1, 116);
			this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialTabSelector1.Name = "materialTabSelector1";
			this.materialTabSelector1.Size = new System.Drawing.Size(646, 30);
			this.materialTabSelector1.TabIndex = 5;
			this.materialTabSelector1.Text = "materialTabSelector1";
			// 
			// lblDetected
			// 
			this.lblDetected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDetected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.lblDetected.Depth = 0;
			this.lblDetected.Font = new System.Drawing.Font("Roboto", 11F);
			this.lblDetected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblDetected.Location = new System.Drawing.Point(-1, 91);
			this.lblDetected.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblDetected.Name = "lblDetected";
			this.lblDetected.Size = new System.Drawing.Size(646, 22);
			this.lblDetected.TabIndex = 13;
			this.lblDetected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblDetected.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseDown);
			// 
			// materialDivider1
			// 
			this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
			this.materialDivider1.Depth = 0;
			this.materialDivider1.Location = new System.Drawing.Point(-1, 63);
			this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialDivider1.Name = "materialDivider1";
			this.materialDivider1.Size = new System.Drawing.Size(646, 67);
			this.materialDivider1.TabIndex = 14;
			this.materialDivider1.Text = "materialDivider1";
			this.materialDivider1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseDown);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(645, 442);
			this.Controls.Add(this.lblDetected);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.materialRaisedButton3);
			this.Controls.Add(this.materialTabSelector1);
			this.Controls.Add(this.materialTabControl1);
			this.Controls.Add(this.materialDivider1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(645, 442);
			this.Name = "Form1";
			this.Text = "Qcean\'s Switch theme injector";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.materialTabControl1.ResumeLayout(false);
			this.PatchListPage.ResumeLayout(false);
			this.PatchListPage.PerformLayout();
			this.ExtractPage.ResumeLayout(false);
			this.ExtractPage.PerformLayout();
			this.InjectPage.ResumeLayout(false);
			this.InjectPage.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
		private System.Windows.Forms.TabPage ExtractPage;
		private System.Windows.Forms.TabPage InjectPage;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private MaterialSkin.Controls.MaterialRaisedButton btnExportBntx;
		private MaterialSkin.Controls.MaterialLabel materialLabel3;
		private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
		private MaterialSkin.Controls.MaterialLabel materialLabel2;
		private System.Windows.Forms.TextBox tbBntxFile;
		private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
		private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
		private System.Windows.Forms.Label label1;
		private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
		private System.Windows.Forms.TabPage PatchListPage;
		private System.Windows.Forms.TextBox tbPatches;
		private MaterialSkin.Controls.MaterialLabel lblDetected;
		private MaterialSkin.Controls.MaterialDivider materialDivider1;
	}
}
