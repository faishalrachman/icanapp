namespace iCAN.GUI.Siswa
{
    partial class DaftarGuruSiswa
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
            this.metroListGuru = new MetroFramework.Controls.MetroListView();
            this.SuspendLayout();
            // 
            // metroListGuru
            // 
            this.metroListGuru.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListGuru.FullRowSelect = true;
            this.metroListGuru.Location = new System.Drawing.Point(24, 84);
            this.metroListGuru.Name = "metroListGuru";
            this.metroListGuru.OwnerDraw = true;
            this.metroListGuru.Size = new System.Drawing.Size(699, 322);
            this.metroListGuru.TabIndex = 0;
            this.metroListGuru.UseCompatibleStateImageBehavior = false;
            this.metroListGuru.UseSelectable = true;
            // 
            // DaftarGuruSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 447);
            this.Controls.Add(this.metroListGuru);
            this.Name = "DaftarGuruSiswa";
            this.Text = "Daftar Guru";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView metroListGuru;
    }
}