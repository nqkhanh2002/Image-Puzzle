namespace WindowsFormsApplication1
{
    partial class frmPuzzleGame
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPuzzleGame));
            this.gbKhung = new System.Windows.Forms.GroupBox();
            this.btnChoiLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblBuocDi = new System.Windows.Forms.Label();
            this.lblThoiGianDem = new System.Windows.Forms.Label();
            this.tmrThoiGianDem = new System.Windows.Forms.Timer(this.components);
            this.btnTamDung = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnGiaiToiUu = new System.Windows.Forms.Button();
            this.lblTimeGiai = new System.Windows.Forms.Label();
            this.lblBuocDuyet = new System.Windows.Forms.Label();
            this.gbAnhGoc = new System.Windows.Forms.GroupBox();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.pbx4 = new System.Windows.Forms.PictureBox();
            this.pbx5 = new System.Windows.Forms.PictureBox();
            this.pbx6 = new System.Windows.Forms.PictureBox();
            this.pbx7 = new System.Windows.Forms.PictureBox();
            this.pbx8 = new System.Windows.Forms.PictureBox();
            this.pbx9 = new System.Windows.Forms.PictureBox();
            this.gbKhung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).BeginInit();
            this.SuspendLayout();
            // 
            // gbKhung
            // 
            this.gbKhung.Controls.Add(this.pbx1);
            this.gbKhung.Controls.Add(this.pbx2);
            this.gbKhung.Controls.Add(this.pbx3);
            this.gbKhung.Controls.Add(this.pbx4);
            this.gbKhung.Controls.Add(this.pbx5);
            this.gbKhung.Controls.Add(this.pbx6);
            this.gbKhung.Controls.Add(this.pbx7);
            this.gbKhung.Controls.Add(this.pbx8);
            this.gbKhung.Controls.Add(this.pbx9);
            resources.ApplyResources(this.gbKhung, "gbKhung");
            this.gbKhung.Name = "gbKhung";
            this.gbKhung.TabStop = false;
            // 
            // btnChoiLai
            // 
            this.btnChoiLai.BackColor = System.Drawing.Color.LightCoral;
            resources.ApplyResources(this.btnChoiLai, "btnChoiLai");
            this.btnChoiLai.Name = "btnChoiLai";
            this.btnChoiLai.UseVisualStyleBackColor = false;
            this.btnChoiLai.Click += new System.EventHandler(this.btnChoiLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightCoral;
            resources.ApplyResources(this.btnThoat, "btnThoat");
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblBuocDi
            // 
            resources.ApplyResources(this.lblBuocDi, "lblBuocDi");
            this.lblBuocDi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBuocDi.Name = "lblBuocDi";
            this.lblBuocDi.Click += new System.EventHandler(this.lblBuocDi_Click);
            // 
            // lblThoiGianDem
            // 
            resources.ApplyResources(this.lblThoiGianDem, "lblThoiGianDem");
            this.lblThoiGianDem.Name = "lblThoiGianDem";
            // 
            // tmrThoiGianDem
            // 
            this.tmrThoiGianDem.Enabled = true;
            this.tmrThoiGianDem.Interval = 900;
            this.tmrThoiGianDem.Tick += new System.EventHandler(this.TinhThoiGian);
            // 
            // btnTamDung
            // 
            this.btnTamDung.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btnTamDung, "btnTamDung");
            this.btnTamDung.Name = "btnTamDung";
            this.btnTamDung.UseVisualStyleBackColor = false;
            this.btnTamDung.Click += new System.EventHandler(this.PauseOrResume);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnGiai_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Yellow;
            resources.ApplyResources(this.btnPrev, "btnPrev");
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnDiLui_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Yellow;
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.Name = "btnNext";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnDiToi_Click);
            // 
            // btnGiaiToiUu
            // 
            this.btnGiaiToiUu.BackColor = System.Drawing.Color.LightPink;
            resources.ApplyResources(this.btnGiaiToiUu, "btnGiaiToiUu");
            this.btnGiaiToiUu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGiaiToiUu.Name = "btnGiaiToiUu";
            this.btnGiaiToiUu.UseVisualStyleBackColor = false;
            this.btnGiaiToiUu.Click += new System.EventHandler(this.btnGiaiToiUu_Click);
            // 
            // lblTimeGiai
            // 
            resources.ApplyResources(this.lblTimeGiai, "lblTimeGiai");
            this.lblTimeGiai.Name = "lblTimeGiai";
            this.lblTimeGiai.Click += new System.EventHandler(this.lblTimeGiai_Click);
            // 
            // lblBuocDuyet
            // 
            resources.ApplyResources(this.lblBuocDuyet, "lblBuocDuyet");
            this.lblBuocDuyet.Name = "lblBuocDuyet";
            // 
            // gbAnhGoc
            // 
            this.gbAnhGoc.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.original;
            resources.ApplyResources(this.gbAnhGoc, "gbAnhGoc");
            this.gbAnhGoc.Name = "gbAnhGoc";
            this.gbAnhGoc.TabStop = false;
            // 
            // pbx1
            // 
            this.pbx1.Image = global::WindowsFormsApplication1.Properties.Resources._1;
            resources.ApplyResources(this.pbx1, "pbx1");
            this.pbx1.Name = "pbx1";
            this.pbx1.TabStop = false;
            this.pbx1.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx2
            // 
            this.pbx2.Image = global::WindowsFormsApplication1.Properties.Resources._2;
            resources.ApplyResources(this.pbx2, "pbx2");
            this.pbx2.Name = "pbx2";
            this.pbx2.TabStop = false;
            this.pbx2.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx3
            // 
            this.pbx3.Image = global::WindowsFormsApplication1.Properties.Resources._3;
            resources.ApplyResources(this.pbx3, "pbx3");
            this.pbx3.Name = "pbx3";
            this.pbx3.TabStop = false;
            this.pbx3.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx4
            // 
            this.pbx4.Image = global::WindowsFormsApplication1.Properties.Resources._4;
            resources.ApplyResources(this.pbx4, "pbx4");
            this.pbx4.Name = "pbx4";
            this.pbx4.TabStop = false;
            this.pbx4.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx5
            // 
            this.pbx5.Image = global::WindowsFormsApplication1.Properties.Resources._5;
            resources.ApplyResources(this.pbx5, "pbx5");
            this.pbx5.Name = "pbx5";
            this.pbx5.TabStop = false;
            this.pbx5.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx6
            // 
            this.pbx6.Image = global::WindowsFormsApplication1.Properties.Resources._6;
            resources.ApplyResources(this.pbx6, "pbx6");
            this.pbx6.Name = "pbx6";
            this.pbx6.TabStop = false;
            this.pbx6.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx7
            // 
            this.pbx7.Image = global::WindowsFormsApplication1.Properties.Resources._7;
            resources.ApplyResources(this.pbx7, "pbx7");
            this.pbx7.Name = "pbx7";
            this.pbx7.TabStop = false;
            this.pbx7.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx8
            // 
            this.pbx8.Image = global::WindowsFormsApplication1.Properties.Resources._8;
            resources.ApplyResources(this.pbx8, "pbx8");
            this.pbx8.Name = "pbx8";
            this.pbx8.TabStop = false;
            this.pbx8.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx9
            // 
            this.pbx9.Image = global::WindowsFormsApplication1.Properties.Resources._9;
            resources.ApplyResources(this.pbx9, "pbx9");
            this.pbx9.Name = "pbx9";
            this.pbx9.TabStop = false;
            this.pbx9.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // frmPuzzleGame
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblBuocDuyet);
            this.Controls.Add(this.lblTimeGiai);
            this.Controls.Add(this.btnGiaiToiUu);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnTamDung);
            this.Controls.Add(this.lblThoiGianDem);
            this.Controls.Add(this.lblBuocDi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChoiLai);
            this.Controls.Add(this.gbAnhGoc);
            this.Controls.Add(this.gbKhung);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPuzzleGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KiemTraThoatChuongTrinh);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbKhung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKhung;
        private System.Windows.Forms.GroupBox gbAnhGoc;
        private System.Windows.Forms.PictureBox pbx3;
        private System.Windows.Forms.PictureBox pbx9;
        private System.Windows.Forms.PictureBox pbx6;
        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.PictureBox pbx8;
        private System.Windows.Forms.PictureBox pbx5;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.PictureBox pbx7;
        private System.Windows.Forms.PictureBox pbx4;
        private System.Windows.Forms.Button btnChoiLai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblBuocDi;
        private System.Windows.Forms.Label lblThoiGianDem;
        private System.Windows.Forms.Timer tmrThoiGianDem;
        private System.Windows.Forms.Button btnTamDung;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnGiaiToiUu;
		private System.Windows.Forms.Label lblTimeGiai;
		private System.Windows.Forms.Label lblBuocDuyet;
	}
}

