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
<<<<<<< HEAD
            this.listNilai = new MetroFramework.Controls.MetroListView();
=======
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroListNilai = new MetroFramework.Controls.MetroListView();
>>>>>>> e97259a59ee2e7786031b49f9f1f6f1cced5142a
            this.SuspendLayout();
            // 
            // listNilai
            // 
<<<<<<< HEAD
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
=======
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(136, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Pilih mata pelajaran : ";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(166, 63);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 1;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroListNilai
            // 
            this.metroListNilai.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListNilai.FullRowSelect = true;
            this.metroListNilai.Location = new System.Drawing.Point(23, 98);
            this.metroListNilai.Name = "metroListNilai";
            this.metroListNilai.OwnerDraw = true;
            this.metroListNilai.Size = new System.Drawing.Size(567, 299);
            this.metroListNilai.TabIndex = 2;
            this.metroListNilai.UseCompatibleStateImageBehavior = false;
            this.metroListNilai.UseSelectable = true;
            this.metroListNilai.SelectedIndexChanged += new System.EventHandler(this.metroListView1_SelectedIndexChanged);
>>>>>>> e97259a59ee2e7786031b49f9f1f6f1cced5142a
            // 
            // frmLihatNilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 412);
<<<<<<< HEAD
            this.Controls.Add(this.listNilai);
=======
            this.Controls.Add(this.metroListNilai);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroLabel1);
>>>>>>> e97259a59ee2e7786031b49f9f1f6f1cced5142a
            this.Name = "frmLihatNilai";
            this.Text = "Lihat Nilai ";
            this.Load += new System.EventHandler(this.frmLihatNilai_Load);
            this.ResumeLayout(false);

        }

        #endregion
<<<<<<< HEAD
        private MetroFramework.Controls.MetroListView listNilai;
=======

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroListView metroListNilai;
>>>>>>> e97259a59ee2e7786031b49f9f1f6f1cced5142a
    }
}