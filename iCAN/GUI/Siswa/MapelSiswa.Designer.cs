namespace iCAN.GUI.Siswa
{
    partial class MapelSiswa
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
            this.metroListMapel = new MetroFramework.Controls.MetroListView();
            this.SuspendLayout();
            // 
            // metroListMapel
            // 
            this.metroListMapel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListMapel.FullRowSelect = true;
            this.metroListMapel.Location = new System.Drawing.Point(24, 78);
            this.metroListMapel.Name = "metroListMapel";
            this.metroListMapel.OwnerDraw = true;
            this.metroListMapel.Size = new System.Drawing.Size(681, 300);
            this.metroListMapel.TabIndex = 0;
            this.metroListMapel.UseCompatibleStateImageBehavior = false;
            this.metroListMapel.UseSelectable = true;
            this.metroListMapel.SelectedIndexChanged += new System.EventHandler(this.metroListMapel_SelectedIndexChanged);
            // 
            // MapelSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 401);
            this.Controls.Add(this.metroListMapel);
            this.Name = "MapelSiswa";
            this.Text = "Mata Pelajaran";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView metroListMapel;
    }
}