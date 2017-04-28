namespace iCAN.GUI.Guru
{
    partial class MainDashboardGuru
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mAbsensi = new MetroFramework.Controls.MetroTile();
            this.mBerita = new MetroFramework.Controls.MetroTile();
            this.mNilai = new MetroFramework.Controls.MetroTile();
            this.mDaftarGuru = new MetroFramework.Controls.MetroTile();
            this.mProfileGuru = new MetroFramework.Controls.MetroTile();
            this.mTanggal = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.mTanggal);
            this.metroPanel1.Controls.Add(this.mProfileGuru);
            this.metroPanel1.Controls.Add(this.mDaftarGuru);
            this.metroPanel1.Controls.Add(this.mNilai);
            this.metroPanel1.Controls.Add(this.mBerita);
            this.metroPanel1.Controls.Add(this.mAbsensi);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(26, 75);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(821, 390);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // mAbsensi
            // 
            this.mAbsensi.ActiveControl = null;
            this.mAbsensi.Location = new System.Drawing.Point(15, 70);
            this.mAbsensi.Name = "mAbsensi";
            this.mAbsensi.Size = new System.Drawing.Size(234, 102);
            this.mAbsensi.TabIndex = 2;
            this.mAbsensi.Text = "Absensi";
            this.mAbsensi.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mAbsensi.UseSelectable = true;
            // 
            // mBerita
            // 
            this.mBerita.ActiveControl = null;
            this.mBerita.Location = new System.Drawing.Point(15, 178);
            this.mBerita.Name = "mBerita";
            this.mBerita.Size = new System.Drawing.Size(234, 97);
            this.mBerita.TabIndex = 3;
            this.mBerita.Text = "Berita ";
            this.mBerita.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mBerita.UseSelectable = true;
            this.mBerita.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // mNilai
            // 
            this.mNilai.ActiveControl = null;
            this.mNilai.Location = new System.Drawing.Point(255, 70);
            this.mNilai.Name = "mNilai";
            this.mNilai.Size = new System.Drawing.Size(164, 205);
            this.mNilai.TabIndex = 4;
            this.mNilai.Text = "Kelola Nilai";
            this.mNilai.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mNilai.UseSelectable = true;
            // 
            // mDaftarGuru
            // 
            this.mDaftarGuru.ActiveControl = null;
            this.mDaftarGuru.Location = new System.Drawing.Point(461, 70);
            this.mDaftarGuru.Name = "mDaftarGuru";
            this.mDaftarGuru.Size = new System.Drawing.Size(168, 102);
            this.mDaftarGuru.TabIndex = 5;
            this.mDaftarGuru.Text = "Daftar Guru";
            this.mDaftarGuru.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mDaftarGuru.UseSelectable = true;
            // 
            // mProfileGuru
            // 
            this.mProfileGuru.ActiveControl = null;
            this.mProfileGuru.Location = new System.Drawing.Point(461, 179);
            this.mProfileGuru.Name = "mProfileGuru";
            this.mProfileGuru.Size = new System.Drawing.Size(168, 96);
            this.mProfileGuru.TabIndex = 6;
            this.mProfileGuru.Text = "Profile";
            this.mProfileGuru.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mProfileGuru.UseSelectable = true;
            // 
            // mTanggal
            // 
            this.mTanggal.ActiveControl = null;
            this.mTanggal.Location = new System.Drawing.Point(635, 70);
            this.mTanggal.Name = "mTanggal";
            this.mTanggal.Size = new System.Drawing.Size(165, 204);
            this.mTanggal.TabIndex = 7;
            this.mTanggal.Text = "Tanggal";
            this.mTanggal.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mTanggal.UseSelectable = true;
            // 
            // MainDashboardGuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 488);
            this.Controls.Add(this.metroPanel1);
            this.Name = "MainDashboardGuru";
            this.Text = "Dashboard Guru";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainDashboardGuru_FormClosed);
            this.Load += new System.EventHandler(this.MainDashboardGuru_Load);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile mBerita;
        private MetroFramework.Controls.MetroTile mAbsensi;
        private MetroFramework.Controls.MetroTile mTanggal;
        private MetroFramework.Controls.MetroTile mProfileGuru;
        private MetroFramework.Controls.MetroTile mDaftarGuru;
        private MetroFramework.Controls.MetroTile mNilai;
    }
}