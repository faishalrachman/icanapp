namespace iCAN.GUI.Siswa
{
    partial class frmLihatNilai
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
            this.listNilai = new MetroFramework.Controls.MetroListView();
            this.SuspendLayout();
            // 
            // listNilai
            // 
            this.listNilai.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listNilai.FullRowSelect = true;
            this.listNilai.Location = new System.Drawing.Point(23, 80);
            this.listNilai.Name = "listNilai";
            this.listNilai.OwnerDraw = true;
            this.listNilai.Size = new System.Drawing.Size(567, 317);
            this.listNilai.TabIndex = 2;
            this.listNilai.UseCompatibleStateImageBehavior = false;
            this.listNilai.UseSelectable = true;
            this.listNilai.View = System.Windows.Forms.View.Details;
            this.listNilai.SelectedIndexChanged += new System.EventHandler(this.metroListView1_SelectedIndexChanged);
            // 
            // frmLihatNilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 412);
            this.Controls.Add(this.listNilai);
            this.Name = "frmLihatNilai";
            this.Text = "Lihat Nilai ";
            this.Load += new System.EventHandler(this.frmLihatNilai_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroListView listNilai;
    }
}