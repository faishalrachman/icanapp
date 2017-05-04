namespace iCAN.GUI.Siswa
{
    partial class MainDashboardSiswa
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
            this.metroDaftarGuru = new MetroFramework.Controls.MetroTile();
            this.metroProfile = new MetroFramework.Controls.MetroTile();
            this.metroBerita = new MetroFramework.Controls.MetroTile();
            this.metroPelajaran = new MetroFramework.Controls.MetroTile();
            this.metroGuru = new MetroFramework.Controls.MetroTile();
            this.metroJadwal = new MetroFramework.Controls.MetroTile();
            this.metroNilai = new MetroFramework.Controls.MetroTile();
            this.txnamaSiswa = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroDaftarGuru);
            this.metroPanel1.Controls.Add(this.metroProfile);
            this.metroPanel1.Controls.Add(this.metroBerita);
            this.metroPanel1.Controls.Add(this.metroPelajaran);
            this.metroPanel1.Controls.Add(this.metroGuru);
            this.metroPanel1.Controls.Add(this.metroJadwal);
            this.metroPanel1.Controls.Add(this.metroNilai);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(11, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(716, 400);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // metroDaftarGuru
            // 
            this.metroDaftarGuru.ActiveControl = null;
            this.metroDaftarGuru.Location = new System.Drawing.Point(13, 256);
            this.metroDaftarGuru.Name = "metroDaftarGuru";
            this.metroDaftarGuru.Size = new System.Drawing.Size(296, 94);
            this.metroDaftarGuru.Style = MetroFramework.MetroColorStyle.Green;
            this.metroDaftarGuru.TabIndex = 10;
            this.metroDaftarGuru.Text = "Daftar Guru";
            this.metroDaftarGuru.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroDaftarGuru.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroDaftarGuru.UseSelectable = true;
            this.metroDaftarGuru.Click += new System.EventHandler(this.metroDaftarGuru_Click);
            // 
            // metroProfile
            // 
            this.metroProfile.ActiveControl = null;
            this.metroProfile.Location = new System.Drawing.Point(507, 150);
            this.metroProfile.Name = "metroProfile";
            this.metroProfile.Size = new System.Drawing.Size(178, 99);
            this.metroProfile.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroProfile.TabIndex = 7;
            this.metroProfile.Text = "Presensi";
            this.metroProfile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroProfile.UseSelectable = true;
            this.metroProfile.Click += new System.EventHandler(this.metroProfile_Click);
            // 
            // metroBerita
            // 
            this.metroBerita.ActiveControl = null;
            this.metroBerita.Location = new System.Drawing.Point(507, 33);
            this.metroBerita.Name = "metroBerita";
            this.metroBerita.Size = new System.Drawing.Size(179, 109);
            this.metroBerita.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroBerita.TabIndex = 6;
            this.metroBerita.Text = "Berita";
            this.metroBerita.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroBerita.UseSelectable = true;
            this.metroBerita.Click += new System.EventHandler(this.metroBerita_Click);
            // 
            // metroPelajaran
            // 
            this.metroPelajaran.ActiveControl = null;
            this.metroPelajaran.Location = new System.Drawing.Point(335, 33);
            this.metroPelajaran.Name = "metroPelajaran";
            this.metroPelajaran.Size = new System.Drawing.Size(167, 109);
            this.metroPelajaran.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroPelajaran.TabIndex = 5;
            this.metroPelajaran.Text = "Mata Pelajaran";
            this.metroPelajaran.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPelajaran.UseSelectable = true;
            this.metroPelajaran.Click += new System.EventHandler(this.metroPelajaran_Click);
            // 
            // metroGuru
            // 
            this.metroGuru.ActiveControl = null;
            this.metroGuru.Location = new System.Drawing.Point(335, 148);
            this.metroGuru.Name = "metroGuru";
            this.metroGuru.Size = new System.Drawing.Size(167, 99);
            this.metroGuru.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroGuru.TabIndex = 4;
            this.metroGuru.Text = "Wali Kelasku";
            this.metroGuru.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroGuru.UseSelectable = true;
            this.metroGuru.Click += new System.EventHandler(this.metroGuru_Click);
            // 
            // metroJadwal
            // 
            this.metroJadwal.ActiveControl = null;
            this.metroJadwal.Location = new System.Drawing.Point(12, 148);
            this.metroJadwal.Name = "metroJadwal";
            this.metroJadwal.Size = new System.Drawing.Size(297, 101);
            this.metroJadwal.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroJadwal.TabIndex = 3;
            this.metroJadwal.Text = "Lihat Jadwal";
            this.metroJadwal.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroJadwal.UseSelectable = true;
            this.metroJadwal.Click += new System.EventHandler(this.metroJadwal_Click);
            // 
            // metroNilai
            // 
            this.metroNilai.ActiveControl = null;
            this.metroNilai.Location = new System.Drawing.Point(12, 33);
            this.metroNilai.Name = "metroNilai";
            this.metroNilai.Size = new System.Drawing.Size(297, 109);
            this.metroNilai.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroNilai.TabIndex = 2;
            this.metroNilai.Text = "Lihat Nilai ";
            this.metroNilai.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.metroNilai.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroNilai.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroNilai.UseSelectable = true;
            this.metroNilai.UseStyleColors = true;
            this.metroNilai.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // txnamaSiswa
            // 
            this.txnamaSiswa.AutoSize = true;
            this.txnamaSiswa.Location = new System.Drawing.Point(404, 31);
            this.txnamaSiswa.Name = "txnamaSiswa";
            this.txnamaSiswa.Size = new System.Drawing.Size(108, 19);
            this.txnamaSiswa.TabIndex = 1;
            this.txnamaSiswa.Text = "Selamat datang, ";
            // 
            // MainDashboardSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 486);
            this.Controls.Add(this.txnamaSiswa);
            this.Controls.Add(this.metroPanel1);
            this.Name = "MainDashboardSiswa";
            this.Text = "Dashboard Siswa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainDashboardSiswa_FormClosing);
            this.Load += new System.EventHandler(this.MainDashboardSiswa_Load);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile metroJadwal;
        private MetroFramework.Controls.MetroTile metroNilai;
        private MetroFramework.Controls.MetroTile metroGuru;
        private MetroFramework.Controls.MetroLabel txnamaSiswa;
        private MetroFramework.Controls.MetroTile metroProfile;
        private MetroFramework.Controls.MetroTile metroBerita;
        private MetroFramework.Controls.MetroTile metroPelajaran;
        private MetroFramework.Controls.MetroTile metroDaftarGuru;
    }
}