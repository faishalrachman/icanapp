namespace iCAN.GUI.Guru
{
    partial class waliKelas
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
            this.metroWali = new MetroFramework.Controls.MetroListView();
            this.SuspendLayout();
            // 
            // metroWali
            // 
            this.metroWali.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroWali.FullRowSelect = true;
            this.metroWali.Location = new System.Drawing.Point(24, 82);
            this.metroWali.Name = "metroWali";
            this.metroWali.OwnerDraw = true;
            this.metroWali.Size = new System.Drawing.Size(508, 273);
            this.metroWali.TabIndex = 0;
            this.metroWali.UseCompatibleStateImageBehavior = false;
            this.metroWali.UseSelectable = true;
            this.metroWali.View = System.Windows.Forms.View.Details;
            // 
            // waliKelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 461);
            this.Controls.Add(this.metroWali);
            this.Name = "waliKelas";
            this.Text = "Wali Kelas";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView metroWali;
    }
}