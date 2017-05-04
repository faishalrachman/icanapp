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
            this.listDaftarSiswa = new MetroFramework.Controls.MetroTile();
            this.mtJadwalGuru = new MetroFramework.Controls.MetroTile();
            this.mMapel = new MetroFramework.Controls.MetroTile();
            this.lb_welcome = new MetroFramework.Controls.MetroLabel();
            this.WaliGuru = new MetroFramework.Controls.MetroTile();
            this.mDaftarGuru = new MetroFramework.Controls.MetroTile();
            this.mNilai = new MetroFramework.Controls.MetroTile();
            this.mBeritaGuru = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.WaliGuru);
            this.metroPanel1.Controls.Add(this.listDaftarSiswa);
            this.metroPanel1.Controls.Add(this.mtJadwalGuru);
            this.metroPanel1.Controls.Add(this.mMapel);
            this.metroPanel1.Controls.Add(this.mDaftarGuru);
            this.metroPanel1.Controls.Add(this.mNilai);
            this.metroPanel1.Controls.Add(this.mBeritaGuru);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(26, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(764, 368);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // listDaftarSiswa
            // 
            this.listDaftarSiswa.ActiveControl = null;
            this.listDaftarSiswa.AutoSize = true;
            this.listDaftarSiswa.Location = new System.Drawing.Point(448, 151);
            this.listDaftarSiswa.Name = "listDaftarSiswa";
            this.listDaftarSiswa.Size = new System.Drawing.Size(297, 115);
            this.listDaftarSiswa.Style = MetroFramework.MetroColorStyle.Orange;
            this.listDaftarSiswa.TabIndex = 9;
            this.listDaftarSiswa.Text = "Daftar Siswa";
            this.listDaftarSiswa.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.listDaftarSiswa.Theme = MetroFramework.MetroThemeStyle.Light;
            this.listDaftarSiswa.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.listDaftarSiswa.UseSelectable = true;
            this.listDaftarSiswa.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // mtJadwalGuru
            // 
            this.mtJadwalGuru.ActiveControl = null;
            this.mtJadwalGuru.Location = new System.Drawing.Point(255, 151);
            this.mtJadwalGuru.Name = "mtJadwalGuru";
            this.mtJadwalGuru.Size = new System.Drawing.Size(164, 115);
            this.mtJadwalGuru.TabIndex = 8;
            this.mtJadwalGuru.Text = "Jadwal";
            this.mtJadwalGuru.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtJadwalGuru.UseSelectable = true;
            this.mtJadwalGuru.Click += new System.EventHandler(this.mtJadwalGuru_Click);
            // 
            // mMapel
            // 
            this.mMapel.ActiveControl = null;
            this.mMapel.Location = new System.Drawing.Point(595, 30);
            this.mMapel.Name = "mMapel";
            this.mMapel.Size = new System.Drawing.Size(150, 114);
            this.mMapel.Style = MetroFramework.MetroColorStyle.Lime;
            this.mMapel.TabIndex = 7;
            this.mMapel.Text = "Mata Pelajaran";
            this.mMapel.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.mMapel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mMapel.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mMapel.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mMapel.UseSelectable = true;
            this.mMapel.UseStyleColors = true;
            this.mMapel.UseTileImage = true;
            this.mMapel.Click += new System.EventHandler(this.mMapel_Click);
            // 
            // lb_welcome
            // 
            this.lb_welcome.AutoSize = true;
            this.lb_welcome.Location = new System.Drawing.Point(474, 24);
            this.lb_welcome.Name = "lb_welcome";
            this.lb_welcome.Size = new System.Drawing.Size(109, 19);
            this.lb_welcome.TabIndex = 10;
            this.lb_welcome.Text = "Selamat Datang, ";
            // 
            // WaliGuru
            // 
            this.WaliGuru.ActiveControl = null;
            this.WaliGuru.Location = new System.Drawing.Point(15, 30);
            this.WaliGuru.Name = "WaliGuru";
            this.WaliGuru.Size = new System.Drawing.Size(234, 115);
            this.WaliGuru.TabIndex = 10;
            this.WaliGuru.Text = "Wali Kelas";
            this.WaliGuru.UseSelectable = true;
            this.WaliGuru.Click += new System.EventHandler(this.WaliGuru_Click);
            // 
            // mDaftarGuru
            // 
            this.mDaftarGuru.ActiveControl = null;
            this.mDaftarGuru.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.mDaftarGuru.Location = new System.Drawing.Point(448, 30);
            this.mDaftarGuru.Name = "mDaftarGuru";
            this.mDaftarGuru.Size = new System.Drawing.Size(141, 115);
            this.mDaftarGuru.Style = MetroFramework.MetroColorStyle.Blue;
            this.mDaftarGuru.TabIndex = 5;
            this.mDaftarGuru.Text = "Daftar Guru";
            this.mDaftarGuru.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.mDaftarGuru.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mDaftarGuru.TileImage = global::iCAN.Properties.Resources.stock_photo_125106373;
            this.mDaftarGuru.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mDaftarGuru.UseSelectable = true;
            this.mDaftarGuru.UseWaitCursor = true;
            this.mDaftarGuru.Click += new System.EventHandler(this.mDaftarGuru_Click);
            // 
            // mNilai
            // 
            this.mNilai.ActiveControl = null;
            this.mNilai.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.mNilai.Location = new System.Drawing.Point(255, 30);
            this.mNilai.Name = "mNilai";
            this.mNilai.Size = new System.Drawing.Size(164, 114);
            this.mNilai.Style = MetroFramework.MetroColorStyle.Teal;
            this.mNilai.TabIndex = 4;
            this.mNilai.Text = "Kelola Nilai";
            this.mNilai.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mNilai.TileImage = global::iCAN.Properties.Resources.stock_photo_125106373;
            this.mNilai.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mNilai.UseSelectable = true;
            this.mNilai.Click += new System.EventHandler(this.mNilai_Click);
            // 
            // mBeritaGuru
            // 
            this.mBeritaGuru.ActiveControl = null;
            this.mBeritaGuru.Location = new System.Drawing.Point(15, 150);
            this.mBeritaGuru.Name = "mBeritaGuru";
            this.mBeritaGuru.Size = new System.Drawing.Size(234, 115);
            this.mBeritaGuru.Style = MetroFramework.MetroColorStyle.Green;
            this.mBeritaGuru.TabIndex = 3;
            this.mBeritaGuru.Text = "Berita ";
            this.mBeritaGuru.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mBeritaGuru.TileImage = global::iCAN.Properties.Resources.stock_photo_125106373;
            this.mBeritaGuru.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mBeritaGuru.UseSelectable = true;
            this.mBeritaGuru.Click += new System.EventHandler(this.mBeritaGuru_Click);
            // 
            // MainDashboardGuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 454);
            this.Controls.Add(this.lb_welcome);
            this.Controls.Add(this.metroPanel1);
            this.Name = "MainDashboardGuru";
            this.Text = "Dashboard Guru";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainDashboardGuru_FormClosed);
            this.Load += new System.EventHandler(this.MainDashboardGuru_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile mBeritaGuru;
        private MetroFramework.Controls.MetroTile mMapel;
        private MetroFramework.Controls.MetroTile mDaftarGuru;
        private MetroFramework.Controls.MetroTile mNilai;
        private MetroFramework.Controls.MetroTile listDaftarSiswa;
        private MetroFramework.Controls.MetroTile mtJadwalGuru;
        private MetroFramework.Controls.MetroLabel lb_welcome;
        private MetroFramework.Controls.MetroTile WaliGuru;
    }
}