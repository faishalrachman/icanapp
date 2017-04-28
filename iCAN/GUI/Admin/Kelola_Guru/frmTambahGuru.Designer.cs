namespace iCAN.GUI.Admin
{
    partial class frmTambahGuru
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
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txPassword = new MetroFramework.Controls.MetroTextBox();
            this.txNama = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txAlamat = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txNIP = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txNoHP = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(29, 296);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(426, 23);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Tambah";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(29, 329);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(427, 23);
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "Reset";
            this.metroButton2.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(26, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "User Name";
            // 
            // txUsername
            // 
            // 
            // 
            // 
            this.txUsername.CustomButton.Image = null;
            this.txUsername.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txUsername.CustomButton.Name = "";
            this.txUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txUsername.CustomButton.TabIndex = 1;
            this.txUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txUsername.CustomButton.UseSelectable = true;
            this.txUsername.CustomButton.Visible = false;
            this.txUsername.Lines = new string[0];
            this.txUsername.Location = new System.Drawing.Point(28, 96);
            this.txUsername.MaxLength = 32767;
            this.txUsername.Name = "txUsername";
            this.txUsername.PasswordChar = '\0';
            this.txUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txUsername.SelectedText = "";
            this.txUsername.SelectionLength = 0;
            this.txUsername.SelectionStart = 0;
            this.txUsername.ShortcutsEnabled = true;
            this.txUsername.Size = new System.Drawing.Size(181, 23);
            this.txUsername.TabIndex = 4;
            this.txUsername.UseSelectable = true;
            this.txUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(27, 122);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Password";
            // 
            // txPassword
            // 
            // 
            // 
            // 
            this.txPassword.CustomButton.Image = null;
            this.txPassword.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.txPassword.CustomButton.Name = "";
            this.txPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txPassword.CustomButton.TabIndex = 1;
            this.txPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txPassword.CustomButton.UseSelectable = true;
            this.txPassword.Lines = new string[0];
            this.txPassword.Location = new System.Drawing.Point(29, 146);
            this.txPassword.MaxLength = 32767;
            this.txPassword.Name = "txPassword";
            this.txPassword.PasswordChar = '*';
            this.txPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txPassword.SelectedText = "";
            this.txPassword.SelectionLength = 0;
            this.txPassword.SelectionStart = 0;
            this.txPassword.ShortcutsEnabled = true;
            this.txPassword.ShowButton = true;
            this.txPassword.ShowClearButton = true;
            this.txPassword.Size = new System.Drawing.Size(180, 23);
            this.txPassword.TabIndex = 6;
            this.txPassword.UseSelectable = true;
            this.txPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txNama
            // 
            // 
            // 
            // 
            this.txNama.CustomButton.Image = null;
            this.txNama.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.txNama.CustomButton.Name = "";
            this.txNama.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txNama.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txNama.CustomButton.TabIndex = 1;
            this.txNama.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txNama.CustomButton.UseSelectable = true;
            this.txNama.CustomButton.Visible = false;
            this.txNama.Lines = new string[0];
            this.txNama.Location = new System.Drawing.Point(273, 146);
            this.txNama.MaxLength = 32767;
            this.txNama.Name = "txNama";
            this.txNama.PasswordChar = '\0';
            this.txNama.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txNama.SelectedText = "";
            this.txNama.SelectionLength = 0;
            this.txNama.SelectionStart = 0;
            this.txNama.ShortcutsEnabled = true;
            this.txNama.Size = new System.Drawing.Size(183, 23);
            this.txNama.TabIndex = 7;
            this.txNama.UseSelectable = true;
            this.txNama.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txNama.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(273, 122);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(77, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Nama Guru";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(25, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 2);
            this.label1.TabIndex = 9;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txAlamat
            // 
            // 
            // 
            // 
            this.txAlamat.CustomButton.Image = null;
            this.txAlamat.CustomButton.Location = new System.Drawing.Point(404, 1);
            this.txAlamat.CustomButton.Name = "";
            this.txAlamat.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txAlamat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txAlamat.CustomButton.TabIndex = 1;
            this.txAlamat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txAlamat.CustomButton.UseSelectable = true;
            this.txAlamat.CustomButton.Visible = false;
            this.txAlamat.Lines = new string[0];
            this.txAlamat.Location = new System.Drawing.Point(29, 251);
            this.txAlamat.MaxLength = 32767;
            this.txAlamat.Name = "txAlamat";
            this.txAlamat.PasswordChar = '\0';
            this.txAlamat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txAlamat.SelectedText = "";
            this.txAlamat.SelectionLength = 0;
            this.txAlamat.SelectionStart = 0;
            this.txAlamat.ShortcutsEnabled = true;
            this.txAlamat.ShowClearButton = true;
            this.txAlamat.Size = new System.Drawing.Size(426, 23);
            this.txAlamat.TabIndex = 13;
            this.txAlamat.UseSelectable = true;
            this.txAlamat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txAlamat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(29, 175);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(99, 19);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "No Handphone";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // txNIP
            // 
            // 
            // 
            // 
            this.txNIP.CustomButton.Image = null;
            this.txNIP.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.txNIP.CustomButton.Name = "";
            this.txNIP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txNIP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txNIP.CustomButton.TabIndex = 1;
            this.txNIP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txNIP.CustomButton.UseSelectable = true;
            this.txNIP.CustomButton.Visible = false;
            this.txNIP.Lines = new string[0];
            this.txNIP.Location = new System.Drawing.Point(273, 96);
            this.txNIP.MaxLength = 32767;
            this.txNIP.Name = "txNIP";
            this.txNIP.PasswordChar = '\0';
            this.txNIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txNIP.SelectedText = "";
            this.txNIP.SelectionLength = 0;
            this.txNIP.SelectionStart = 0;
            this.txNIP.ShortcutsEnabled = true;
            this.txNIP.Size = new System.Drawing.Size(182, 23);
            this.txNIP.TabIndex = 17;
            this.txNIP.UseSelectable = true;
            this.txNIP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txNIP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(29, 229);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(51, 19);
            this.metroLabel7.TabIndex = 23;
            this.metroLabel7.Text = "Alamat";
            this.metroLabel7.Click += new System.EventHandler(this.metroLabel7_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(273, 74);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(30, 19);
            this.metroLabel9.TabIndex = 25;
            this.metroLabel9.Text = "NIP";
            // 
            // txNoHP
            // 
            // 
            // 
            // 
            this.txNoHP.CustomButton.Image = null;
            this.txNoHP.CustomButton.Location = new System.Drawing.Point(404, 1);
            this.txNoHP.CustomButton.Name = "";
            this.txNoHP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txNoHP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txNoHP.CustomButton.TabIndex = 1;
            this.txNoHP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txNoHP.CustomButton.UseSelectable = true;
            this.txNoHP.CustomButton.Visible = false;
            this.txNoHP.Lines = new string[0];
            this.txNoHP.Location = new System.Drawing.Point(29, 197);
            this.txNoHP.MaxLength = 32767;
            this.txNoHP.Name = "txNoHP";
            this.txNoHP.PasswordChar = '\0';
            this.txNoHP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txNoHP.SelectedText = "";
            this.txNoHP.SelectionLength = 0;
            this.txNoHP.SelectionStart = 0;
            this.txNoHP.ShortcutsEnabled = true;
            this.txNoHP.Size = new System.Drawing.Size(426, 23);
            this.txNoHP.TabIndex = 26;
            this.txNoHP.UseSelectable = true;
            this.txNoHP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txNoHP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmTambahGuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(498, 366);
            this.Controls.Add(this.txNoHP);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txNIP);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txAlamat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txNama);
            this.Controls.Add(this.txPassword);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txUsername);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.MaximizeBox = false;
            this.Name = "frmTambahGuru";
            this.Resizable = false;
            this.Text = "Tambah Guru";
            this.Load += new System.EventHandler(this.frmTambahGuru_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txUsername;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txPassword;
        private MetroFramework.Controls.MetroTextBox txNama;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txAlamat;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txNIP;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txNoHP;
    }
}