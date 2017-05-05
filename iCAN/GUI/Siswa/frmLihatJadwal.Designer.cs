namespace iCAN.GUI.Siswa
{
    partial class frmLihatJadwal
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
            this.lvjawalsiswa = new MetroFramework.Controls.MetroListView();
            this.SuspendLayout();
            // 
            // lvjawalsiswa
            // 
            this.lvjawalsiswa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvjawalsiswa.FullRowSelect = true;
            this.lvjawalsiswa.Location = new System.Drawing.Point(24, 63);
            this.lvjawalsiswa.Name = "lvjawalsiswa";
            this.lvjawalsiswa.OwnerDraw = true;
            this.lvjawalsiswa.Size = new System.Drawing.Size(486, 253);
            this.lvjawalsiswa.TabIndex = 0;
            this.lvjawalsiswa.UseCompatibleStateImageBehavior = false;
            this.lvjawalsiswa.UseSelectable = true;
            this.lvjawalsiswa.View = System.Windows.Forms.View.Details;
            // 
            // frmLihatJadwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 329);
            this.Controls.Add(this.lvjawalsiswa);
            this.Name = "frmLihatJadwal";
            this.Text = "Lihat Jadwal";
            this.Load += new System.EventHandler(this.frmLihatJadwal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView lvjawalsiswa;
    }
}