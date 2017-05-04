namespace iCAN.GUI.Guru
{
    partial class JadwalGuru
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
            this.listViewJadwal = new MetroFramework.Controls.MetroListView();
            this.SuspendLayout();
            // 
            // listViewJadwal
            // 
            this.listViewJadwal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listViewJadwal.FullRowSelect = true;
            this.listViewJadwal.Location = new System.Drawing.Point(34, 92);
            this.listViewJadwal.Name = "listViewJadwal";
            this.listViewJadwal.OwnerDraw = true;
            this.listViewJadwal.Size = new System.Drawing.Size(713, 313);
            this.listViewJadwal.TabIndex = 0;
            this.listViewJadwal.UseCompatibleStateImageBehavior = false;
            this.listViewJadwal.UseSelectable = true;
            this.listViewJadwal.View = System.Windows.Forms.View.Details;
            this.listViewJadwal.SelectedIndexChanged += new System.EventHandler(this.metroListView1_SelectedIndexChanged);
            // 
            // JadwalGuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 459);
            this.Controls.Add(this.listViewJadwal);
            this.Name = "JadwalGuru";
            this.Text = "Jadwal Guru";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView listViewJadwal;
    }
}