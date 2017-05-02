namespace iCAN.GUI.Guru
{
    partial class BeritaGuru
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.txBerita = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(208, 463);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Next";
            this.metroButton1.UseSelectable = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(127, 463);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // txBerita
            // 
            this.txBerita.Location = new System.Drawing.Point(96, 64);
            this.txBerita.MaxLength = 99999999;
            this.txBerita.Multiline = true;
            this.txBerita.Name = "txBerita";
            this.txBerita.Size = new System.Drawing.Size(582, 393);
            this.txBerita.TabIndex = 3;
            // 
            // BeritaGuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 507);
            this.Controls.Add(this.txBerita);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.metroButton1);
            this.Name = "BeritaGuru";
            this.Text = "Berita";
            this.Load += new System.EventHandler(this.BeritaGuru_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txBerita;
    }
}