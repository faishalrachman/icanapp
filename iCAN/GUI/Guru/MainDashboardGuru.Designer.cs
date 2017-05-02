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
            this.mTanggal = new MetroFramework.Controls.MetroTile();
            this.mProfileGuru = new MetroFramework.Controls.MetroTile();
            this.mDaftarGuru = new MetroFramework.Controls.MetroTile();
            this.mNilai = new MetroFramework.Controls.MetroTile();
            this.mAbsensi = new MetroFramework.Controls.MetroTile();
            this.mBeritaGuru = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.mTanggal);
            this.metroPanel1.Controls.Add(this.mProfileGuru);
            this.metroPanel1.Controls.Add(this.mDaftarGuru);
            this.metroPanel1.Controls.Add(this.mNilai);
            this.metroPanel1.Controls.Add(this.mBeritaGuru);
            this.metroPanel1.Controls.Add(this.mAbsensi);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(26, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(802, 307);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // mTanggal
            // 
            this.mTanggal.ActiveControl = null;
            this.mTanggal.Location = new System.Drawing.Point(622, 71);
            this.mTanggal.Name = "mTanggal";
            this.mTanggal.Size = new System.Drawing.Size(165, 204);
            this.mTanggal.Style = MetroFramework.MetroColorStyle.Lime;
            this.mTanggal.TabIndex = 7;
            this.mTanggal.Text = "Tanggal";
            this.mTanggal.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.mTanggal.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTanggal.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTanggal.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mTanggal.UseSelectable = true;
            this.mTanggal.UseStyleColors = true;
            this.mTanggal.UseTileImage = true;
            // 
            // mProfileGuru
            // 
            this.mProfileGuru.ActiveControl = null;
            this.mProfileGuru.Location = new System.Drawing.Point(448, 178);
            this.mProfileGuru.Name = "mProfileGuru";
            this.mProfileGuru.Size = new System.Drawing.Size(168, 96);
            this.mProfileGuru.Style = MetroFramework.MetroColorStyle.Pink;
            this.mProfileGuru.TabIndex = 6;
            this.mProfileGuru.Text = "Profile";
            this.mProfileGuru.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mProfileGuru.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mProfileGuru.UseSelectable = true;
            // 
            // mDaftarGuru
            // 
            this.mDaftarGuru.ActiveControl = null;
            this.mDaftarGuru.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.mDaftarGuru.Location = new System.Drawing.Point(448, 70);
            this.mDaftarGuru.Name = "mDaftarGuru";
            this.mDaftarGuru.Size = new System.Drawing.Size(168, 102);
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
            this.mNilai.Location = new System.Drawing.Point(255, 70);
            this.mNilai.Name = "mNilai";
            this.mNilai.Size = new System.Drawing.Size(164, 205);
            this.mNilai.Style = MetroFramework.MetroColorStyle.Teal;
            this.mNilai.TabIndex = 4;
            this.mNilai.Text = "Kelola Nilai";
            this.mNilai.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mNilai.TileImage = global::iCAN.Properties.Resources.stock_photo_125106373;
            this.mNilai.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mNilai.UseSelectable = true;
            this.mNilai.Click += new System.EventHandler(this.mNilai_Click);
            // 
            // mAbsensi
            // 
            this.mAbsensi.ActiveControl = null;
            this.mAbsensi.Location = new System.Drawing.Point(15, 70);
            this.mAbsensi.Name = "mAbsensi";
            this.mAbsensi.Size = new System.Drawing.Size(234, 102);
            this.mAbsensi.Style = MetroFramework.MetroColorStyle.Orange;
            this.mAbsensi.TabIndex = 2;
            this.mAbsensi.Text = "Absensi";
            this.mAbsensi.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mAbsensi.TileImage = global::iCAN.Properties.Resources.stock_photo_125106373;
            this.mAbsensi.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mAbsensi.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mAbsensi.UseSelectable = true;
            this.mAbsensi.Click += new System.EventHandler(this.mAbsensi_Click);
            // 
            // mBeritaGuru
            // 
            this.mBeritaGuru.ActiveControl = null;
            this.mBeritaGuru.Location = new System.Drawing.Point(15, 178);
            this.mBeritaGuru.Name = "mBeritaGuru";
            this.mBeritaGuru.Size = new System.Drawing.Size(234, 97);
            this.mBeritaGuru.Style = MetroFramework.MetroColorStyle.Green;
            this.mBeritaGuru.TabIndex = 3;
            this.mBeritaGuru.Text = "Berita ";
            this.mBeritaGuru.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mBeritaGuru.TileImage = global::iCAN.Properties.Resources.stock_photo_125106373;
            this.mBeritaGuru.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mBeritaGuru.UseSelectable = true;
            this.mBeritaGuru.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // MainDashboardGuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 433);
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
        private MetroFramework.Controls.MetroTile mBeritaGuru;
        private MetroFramework.Controls.MetroTile mAbsensi;
        private MetroFramework.Controls.MetroTile mTanggal;
        private MetroFramework.Controls.MetroTile mProfileGuru;
        private MetroFramework.Controls.MetroTile mDaftarGuru;
        private MetroFramework.Controls.MetroTile mNilai;
    }
}