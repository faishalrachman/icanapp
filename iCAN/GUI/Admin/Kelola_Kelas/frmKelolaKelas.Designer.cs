namespace iCAN.GUI.Admin
{
    partial class frmKelolaKelas
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
            this.tb_jadwal = new MetroFramework.Controls.MetroListView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txNamaKelas = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.txNamaWali = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // tb_jadwal
            // 
            this.tb_jadwal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tb_jadwal.FullRowSelect = true;
            this.tb_jadwal.Location = new System.Drawing.Point(23, 135);
            this.tb_jadwal.Name = "tb_jadwal";
            this.tb_jadwal.OwnerDraw = true;
            this.tb_jadwal.Size = new System.Drawing.Size(426, 278);
            this.tb_jadwal.TabIndex = 0;
            this.tb_jadwal.UseCompatibleStateImageBehavior = false;
            this.tb_jadwal.UseSelectable = true;
            this.tb_jadwal.View = System.Windows.Forms.View.Details;
            this.tb_jadwal.SelectedIndexChanged += new System.EventHandler(this.tb_jadwal_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Nama Kelas ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 94);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Nama Wali";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 437);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Tambah";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txNamaKelas
            // 
            // 
            // 
            // 
            this.txNamaKelas.CustomButton.Image = null;
            this.txNamaKelas.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.txNamaKelas.CustomButton.Name = "";
            this.txNamaKelas.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txNamaKelas.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txNamaKelas.CustomButton.TabIndex = 1;
            this.txNamaKelas.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txNamaKelas.CustomButton.UseSelectable = true;
            this.txNamaKelas.CustomButton.Visible = false;
            this.txNamaKelas.Lines = new string[0];
            this.txNamaKelas.Location = new System.Drawing.Point(157, 64);
            this.txNamaKelas.MaxLength = 32767;
            this.txNamaKelas.Name = "txNamaKelas";
            this.txNamaKelas.PasswordChar = '\0';
            this.txNamaKelas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txNamaKelas.SelectedText = "";
            this.txNamaKelas.SelectionLength = 0;
            this.txNamaKelas.SelectionStart = 0;
            this.txNamaKelas.ShortcutsEnabled = true;
            this.txNamaKelas.Size = new System.Drawing.Size(160, 23);
            this.txNamaKelas.TabIndex = 5;
            this.txNamaKelas.UseSelectable = true;
            this.txNamaKelas.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txNamaKelas.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txNamaKelas.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(374, 437);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 6;
            this.metroButton2.Text = "Hapus";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // txNamaWali
            // 
            // 
            // 
            // 
            this.txNamaWali.CustomButton.Image = null;
            this.txNamaWali.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.txNamaWali.CustomButton.Name = "";
            this.txNamaWali.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txNamaWali.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txNamaWali.CustomButton.TabIndex = 1;
            this.txNamaWali.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txNamaWali.CustomButton.UseSelectable = true;
            this.txNamaWali.CustomButton.Visible = false;
            this.txNamaWali.Lines = new string[0];
            this.txNamaWali.Location = new System.Drawing.Point(157, 94);
            this.txNamaWali.MaxLength = 32767;
            this.txNamaWali.Name = "txNamaWali";
            this.txNamaWali.PasswordChar = '\0';
            this.txNamaWali.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txNamaWali.SelectedText = "";
            this.txNamaWali.SelectionLength = 0;
            this.txNamaWali.SelectionStart = 0;
            this.txNamaWali.ShortcutsEnabled = true;
            this.txNamaWali.Size = new System.Drawing.Size(160, 23);
            this.txNamaWali.TabIndex = 7;
            this.txNamaWali.UseSelectable = true;
            this.txNamaWali.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txNamaWali.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmKelolaKelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 472);
            this.Controls.Add(this.txNamaWali);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.txNamaKelas);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tb_jadwal);
            this.Name = "frmKelolaKelas";
            this.ShowIcon = false;
            this.Text = "Kelola Kelas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroListView tb_jadwal;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txNamaKelas;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox txNamaWali;
    }
}