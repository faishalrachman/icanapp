namespace iCAN.GUI.Admin
{
    partial class frmKelolaMapel
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tb_mapel = new MetroFramework.Controls.MetroListView();
            this.txKdMapel = new MetroFramework.Controls.MetroTextBox();
            this.txNamaMapel = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.txGuru = new MetroFramework.Controls.MetroTextBox();
            this.txRuangan = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(138, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Kode Mata Pelajaran :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 102);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(144, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Nama Mata Pelajaran :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 135);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(84, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Nama Guru :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(24, 170);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(67, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Ruangan :";
            // 
            // tb_mapel
            // 
            this.tb_mapel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tb_mapel.FullRowSelect = true;
            this.tb_mapel.Location = new System.Drawing.Point(24, 210);
            this.tb_mapel.Name = "tb_mapel";
            this.tb_mapel.OwnerDraw = true;
            this.tb_mapel.Size = new System.Drawing.Size(484, 302);
            this.tb_mapel.TabIndex = 4;
            this.tb_mapel.UseCompatibleStateImageBehavior = false;
            this.tb_mapel.UseSelectable = true;
            this.tb_mapel.View = System.Windows.Forms.View.Details;
            this.tb_mapel.SelectedIndexChanged += new System.EventHandler(this.tb_mapel_SelectedIndexChanged);
            // 
            // txKdMapel
            // 
            // 
            // 
            // 
            this.txKdMapel.CustomButton.Image = null;
            this.txKdMapel.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.txKdMapel.CustomButton.Name = "";
            this.txKdMapel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txKdMapel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txKdMapel.CustomButton.TabIndex = 1;
            this.txKdMapel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txKdMapel.CustomButton.UseSelectable = true;
            this.txKdMapel.CustomButton.Visible = false;
            this.txKdMapel.Enabled = false;
            this.txKdMapel.Lines = new string[0];
            this.txKdMapel.Location = new System.Drawing.Point(167, 73);
            this.txKdMapel.MaxLength = 32767;
            this.txKdMapel.Name = "txKdMapel";
            this.txKdMapel.PasswordChar = '\0';
            this.txKdMapel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txKdMapel.SelectedText = "";
            this.txKdMapel.SelectionLength = 0;
            this.txKdMapel.SelectionStart = 0;
            this.txKdMapel.ShortcutsEnabled = true;
            this.txKdMapel.Size = new System.Drawing.Size(175, 23);
            this.txKdMapel.TabIndex = 5;
            this.txKdMapel.UseSelectable = true;
            this.txKdMapel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txKdMapel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txNamaMapel
            // 
            // 
            // 
            // 
            this.txNamaMapel.CustomButton.Image = null;
            this.txNamaMapel.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.txNamaMapel.CustomButton.Name = "";
            this.txNamaMapel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txNamaMapel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txNamaMapel.CustomButton.TabIndex = 1;
            this.txNamaMapel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txNamaMapel.CustomButton.UseSelectable = true;
            this.txNamaMapel.CustomButton.Visible = false;
            this.txNamaMapel.Enabled = false;
            this.txNamaMapel.Lines = new string[0];
            this.txNamaMapel.Location = new System.Drawing.Point(167, 102);
            this.txNamaMapel.MaxLength = 32767;
            this.txNamaMapel.Name = "txNamaMapel";
            this.txNamaMapel.PasswordChar = '\0';
            this.txNamaMapel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txNamaMapel.SelectedText = "";
            this.txNamaMapel.SelectionLength = 0;
            this.txNamaMapel.SelectionStart = 0;
            this.txNamaMapel.ShortcutsEnabled = true;
            this.txNamaMapel.Size = new System.Drawing.Size(175, 23);
            this.txNamaMapel.TabIndex = 7;
            this.txNamaMapel.UseSelectable = true;
            this.txNamaMapel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txNamaMapel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(386, 73);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(122, 27);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Tambah";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(386, 135);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(122, 27);
            this.metroButton2.TabIndex = 9;
            this.metroButton2.Text = "Hapus";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // txGuru
            // 
            // 
            // 
            // 
            this.txGuru.CustomButton.Image = null;
            this.txGuru.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.txGuru.CustomButton.Name = "";
            this.txGuru.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txGuru.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txGuru.CustomButton.TabIndex = 1;
            this.txGuru.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txGuru.CustomButton.UseSelectable = true;
            this.txGuru.CustomButton.Visible = false;
            this.txGuru.Enabled = false;
            this.txGuru.Lines = new string[0];
            this.txGuru.Location = new System.Drawing.Point(167, 135);
            this.txGuru.MaxLength = 32767;
            this.txGuru.Name = "txGuru";
            this.txGuru.PasswordChar = '\0';
            this.txGuru.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txGuru.SelectedText = "";
            this.txGuru.SelectionLength = 0;
            this.txGuru.SelectionStart = 0;
            this.txGuru.ShortcutsEnabled = true;
            this.txGuru.Size = new System.Drawing.Size(175, 23);
            this.txGuru.TabIndex = 11;
            this.txGuru.UseSelectable = true;
            this.txGuru.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txGuru.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txRuangan
            // 
            // 
            // 
            // 
            this.txRuangan.CustomButton.Image = null;
            this.txRuangan.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.txRuangan.CustomButton.Name = "";
            this.txRuangan.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txRuangan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txRuangan.CustomButton.TabIndex = 1;
            this.txRuangan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txRuangan.CustomButton.UseSelectable = true;
            this.txRuangan.CustomButton.Visible = false;
            this.txRuangan.Enabled = false;
            this.txRuangan.Lines = new string[0];
            this.txRuangan.Location = new System.Drawing.Point(167, 165);
            this.txRuangan.MaxLength = 32767;
            this.txRuangan.Name = "txRuangan";
            this.txRuangan.PasswordChar = '\0';
            this.txRuangan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txRuangan.SelectedText = "";
            this.txRuangan.SelectionLength = 0;
            this.txRuangan.SelectionStart = 0;
            this.txRuangan.ShortcutsEnabled = true;
            this.txRuangan.Size = new System.Drawing.Size(175, 23);
            this.txRuangan.TabIndex = 12;
            this.txRuangan.UseSelectable = true;
            this.txRuangan.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txRuangan.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmKelolaMapel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 520);
            this.Controls.Add(this.txRuangan);
            this.Controls.Add(this.txGuru);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txNamaMapel);
            this.Controls.Add(this.txKdMapel);
            this.Controls.Add(this.tb_mapel);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "frmKelolaMapel";
            this.Text = "Kelola Mata Pelajaran";
            this.Load += new System.EventHandler(this.frmKelolaMapel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroListView tb_mapel;
        private MetroFramework.Controls.MetroTextBox txKdMapel;
        private MetroFramework.Controls.MetroTextBox txNamaMapel;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox txGuru;
        private MetroFramework.Controls.MetroTextBox txRuangan;
    }
}