namespace iCAN.GUI.Guru
{
    partial class DaftarGuru
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
            this.listViewGuru = new MetroFramework.Controls.MetroListView();
            this.Nama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Alamat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Handphone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.listViewGuru);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(24, 82);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(798, 418);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // listViewGuru
            // 
            this.listViewGuru.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nama,
            this.NIP,
            this.Alamat,
            this.Handphone});
            this.listViewGuru.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listViewGuru.FullRowSelect = true;
            this.listViewGuru.Location = new System.Drawing.Point(17, 16);
            this.listViewGuru.Name = "listViewGuru";
            this.listViewGuru.OwnerDraw = true;
            this.listViewGuru.Size = new System.Drawing.Size(766, 391);
            this.listViewGuru.TabIndex = 2;
            this.listViewGuru.UseCompatibleStateImageBehavior = false;
            this.listViewGuru.UseSelectable = true;
            this.listViewGuru.View = System.Windows.Forms.View.Details;
            // 
            // NIP
            // 
            this.NIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Alamat
            // 
            this.Alamat.Text = "Alamat";
            this.Alamat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Handphone
            // 
            this.Handphone.Text = "Nomor Handphone";
            // 
            // DaftarGuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 512);
            this.Controls.Add(this.metroPanel1);
            this.Name = "DaftarGuru";
            this.Text = "Daftar Guru";
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroListView listViewGuru;
        private System.Windows.Forms.ColumnHeader Nama;
        private System.Windows.Forms.ColumnHeader NIP;
        private System.Windows.Forms.ColumnHeader Alamat;
        private System.Windows.Forms.ColumnHeader Handphone;
    }
}