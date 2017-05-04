namespace iCAN.GUI.Siswa
{
    partial class frmGuruku
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
            this.txNIP = new MetroFramework.Controls.MetroTextBox();
            this.txNama = new MetroFramework.Controls.MetroTextBox();
            this.txAlamat = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txNomorHP = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
=======
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel3 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txNIP = new MetroFramework.Controls.MetroTextBox();
            this.txNama = new MetroFramework.Controls.MetroTextBox();
            this.txMengajar = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel4 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txAlamat = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(34, 23);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(24, 64);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(72, 24);
            this.htmlLabel1.TabIndex = 0;
            this.htmlLabel1.Text = "NIP :";
            this.htmlLabel1.Click += new System.EventHandler(this.htmlLabel1_Click);
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(45, 23);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Location = new System.Drawing.Point(24, 94);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(49, 23);
            this.htmlLabel2.TabIndex = 1;
            this.htmlLabel2.Text = "Nama :";
            // 
            // htmlLabel3
            // 
            this.htmlLabel3.AutoScroll = true;
            this.htmlLabel3.AutoScrollMinSize = new System.Drawing.Size(62, 23);
            this.htmlLabel3.AutoSize = false;
            this.htmlLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel3.Location = new System.Drawing.Point(23, 150);
            this.htmlLabel3.Name = "htmlLabel3";
            this.htmlLabel3.Size = new System.Drawing.Size(72, 23);
            this.htmlLabel3.TabIndex = 2;
            this.htmlLabel3.Text = "Mengajar :";
            this.htmlLabel3.Click += new System.EventHandler(this.htmlLabel3_Click);
            // 
>>>>>>> e97259a59ee2e7786031b49f9f1f6f1cced5142a
            // txNIP
            // 
            // 
            // 
            // 
            this.txNIP.CustomButton.Image = null;
            this.txNIP.CustomButton.Location = new System.Drawing.Point(88, 1);
            this.txNIP.CustomButton.Name = "";
            this.txNIP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txNIP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txNIP.CustomButton.TabIndex = 1;
            this.txNIP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txNIP.CustomButton.UseSelectable = true;
            this.txNIP.CustomButton.Visible = false;
            this.txNIP.Lines = new string[] {
        "                            "};
            this.txNIP.Location = new System.Drawing.Point(102, 63);
            this.txNIP.MaxLength = 32767;
            this.txNIP.Name = "txNIP";
            this.txNIP.PasswordChar = '\0';
            this.txNIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txNIP.SelectedText = "";
            this.txNIP.SelectionLength = 0;
            this.txNIP.SelectionStart = 0;
            this.txNIP.ShortcutsEnabled = true;
            this.txNIP.Size = new System.Drawing.Size(110, 23);
            this.txNIP.TabIndex = 3;
            this.txNIP.Text = "                            ";
            this.txNIP.UseSelectable = true;
            this.txNIP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txNIP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txNIP.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // txNama
            // 
            // 
            // 
            // 
            this.txNama.CustomButton.Image = null;
            this.txNama.CustomButton.Location = new System.Drawing.Point(88, 1);
            this.txNama.CustomButton.Name = "";
            this.txNama.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txNama.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txNama.CustomButton.TabIndex = 1;
            this.txNama.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txNama.CustomButton.UseSelectable = true;
            this.txNama.CustomButton.Visible = false;
            this.txNama.Lines = new string[] {
        "                             "};
            this.txNama.Location = new System.Drawing.Point(102, 93);
            this.txNama.MaxLength = 32767;
            this.txNama.Name = "txNama";
            this.txNama.PasswordChar = '\0';
            this.txNama.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txNama.SelectedText = "";
            this.txNama.SelectionLength = 0;
            this.txNama.SelectionStart = 0;
            this.txNama.ShortcutsEnabled = true;
            this.txNama.Size = new System.Drawing.Size(110, 23);
            this.txNama.TabIndex = 4;
            this.txNama.Text = "                             ";
            this.txNama.UseSelectable = true;
            this.txNama.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txNama.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
<<<<<<< HEAD
=======
            // txMengajar
            // 
            // 
            // 
            // 
            this.txMengajar.CustomButton.Image = null;
            this.txMengajar.CustomButton.Location = new System.Drawing.Point(88, 1);
            this.txMengajar.CustomButton.Name = "";
            this.txMengajar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txMengajar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txMengajar.CustomButton.TabIndex = 1;
            this.txMengajar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txMengajar.CustomButton.UseSelectable = true;
            this.txMengajar.CustomButton.Visible = false;
            this.txMengajar.Lines = new string[] {
        "                           "};
            this.txMengajar.Location = new System.Drawing.Point(102, 150);
            this.txMengajar.MaxLength = 32767;
            this.txMengajar.Name = "txMengajar";
            this.txMengajar.PasswordChar = '\0';
            this.txMengajar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txMengajar.SelectedText = "";
            this.txMengajar.SelectionLength = 0;
            this.txMengajar.SelectionStart = 0;
            this.txMengajar.ShortcutsEnabled = true;
            this.txMengajar.Size = new System.Drawing.Size(110, 23);
            this.txMengajar.TabIndex = 5;
            this.txMengajar.Text = "                           ";
            this.txMengajar.UseSelectable = true;
            this.txMengajar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txMengajar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // htmlLabel4
            // 
            this.htmlLabel4.AutoScroll = true;
            this.htmlLabel4.AutoScrollMinSize = new System.Drawing.Size(53, 23);
            this.htmlLabel4.AutoSize = false;
            this.htmlLabel4.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel4.Location = new System.Drawing.Point(24, 124);
            this.htmlLabel4.Name = "htmlLabel4";
            this.htmlLabel4.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel4.TabIndex = 6;
            this.htmlLabel4.Text = "Alamat : ";
            // 
>>>>>>> e97259a59ee2e7786031b49f9f1f6f1cced5142a
            // txAlamat
            // 
            // 
            // 
            // 
            this.txAlamat.CustomButton.Image = null;
            this.txAlamat.CustomButton.Location = new System.Drawing.Point(88, 1);
            this.txAlamat.CustomButton.Name = "";
            this.txAlamat.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txAlamat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txAlamat.CustomButton.TabIndex = 1;
            this.txAlamat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txAlamat.CustomButton.UseSelectable = true;
            this.txAlamat.CustomButton.Visible = false;
            this.txAlamat.Lines = new string[] {
<<<<<<< HEAD
        "                             "};
            this.txAlamat.Location = new System.Drawing.Point(102, 124);
=======
        " "};
            this.txAlamat.Location = new System.Drawing.Point(102, 123);
>>>>>>> e97259a59ee2e7786031b49f9f1f6f1cced5142a
            this.txAlamat.MaxLength = 32767;
            this.txAlamat.Name = "txAlamat";
            this.txAlamat.PasswordChar = '\0';
            this.txAlamat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txAlamat.SelectedText = "";
            this.txAlamat.SelectionLength = 0;
            this.txAlamat.SelectionStart = 0;
            this.txAlamat.ShortcutsEnabled = true;
            this.txAlamat.Size = new System.Drawing.Size(110, 23);
<<<<<<< HEAD
            this.txAlamat.TabIndex = 5;
            this.txAlamat.Text = "                             ";
            this.txAlamat.UseSelectable = true;
            this.txAlamat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txAlamat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 93);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Nama :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 63);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(37, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "NIP :";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 124);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(58, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Alamat :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(24, 157);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(80, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Nomor HP :";
            // 
            // txNomorHP
            // 
            // 
            // 
            // 
            this.txNomorHP.CustomButton.Image = null;
            this.txNomorHP.CustomButton.Location = new System.Drawing.Point(88, 1);
            this.txNomorHP.CustomButton.Name = "";
            this.txNomorHP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txNomorHP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txNomorHP.CustomButton.TabIndex = 1;
            this.txNomorHP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txNomorHP.CustomButton.UseSelectable = true;
            this.txNomorHP.CustomButton.Visible = false;
            this.txNomorHP.Lines = new string[] {
        "                             "};
            this.txNomorHP.Location = new System.Drawing.Point(102, 153);
            this.txNomorHP.MaxLength = 32767;
            this.txNomorHP.Name = "txNomorHP";
            this.txNomorHP.PasswordChar = '\0';
            this.txNomorHP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txNomorHP.SelectedText = "";
            this.txNomorHP.SelectionLength = 0;
            this.txNomorHP.SelectionStart = 0;
            this.txNomorHP.ShortcutsEnabled = true;
            this.txNomorHP.Size = new System.Drawing.Size(110, 23);
            this.txNomorHP.TabIndex = 10;
            this.txNomorHP.Text = "                             ";
            this.txNomorHP.UseSelectable = true;
            this.txNomorHP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txNomorHP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
=======
            this.txAlamat.TabIndex = 7;
            this.txAlamat.Text = " ";
            this.txAlamat.UseSelectable = true;
            this.txAlamat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txAlamat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
>>>>>>> e97259a59ee2e7786031b49f9f1f6f1cced5142a
            // 
            // frmGuruku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(288, 219);
            this.Controls.Add(this.txNomorHP);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txAlamat);
            this.Controls.Add(this.txNama);
            this.Controls.Add(this.txNIP);
=======
            this.ClientSize = new System.Drawing.Size(631, 364);
            this.Controls.Add(this.txAlamat);
            this.Controls.Add(this.htmlLabel4);
            this.Controls.Add(this.txMengajar);
            this.Controls.Add(this.txNama);
            this.Controls.Add(this.txNIP);
            this.Controls.Add(this.htmlLabel3);
            this.Controls.Add(this.htmlLabel2);
            this.Controls.Add(this.htmlLabel1);
>>>>>>> e97259a59ee2e7786031b49f9f1f6f1cced5142a
            this.Name = "frmGuruku";
            this.Text = "Wali Kelas";
            this.Load += new System.EventHandler(this.frmGuruku_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
<<<<<<< HEAD
        private MetroFramework.Controls.MetroTextBox txNIP;
        private MetroFramework.Controls.MetroTextBox txNama;
        private MetroFramework.Controls.MetroTextBox txAlamat;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txNomorHP;
=======

        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel3;
        private MetroFramework.Controls.MetroTextBox txNIP;
        private MetroFramework.Controls.MetroTextBox txNama;
        private MetroFramework.Controls.MetroTextBox txMengajar;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel4;
        private MetroFramework.Controls.MetroTextBox txAlamat;
>>>>>>> e97259a59ee2e7786031b49f9f1f6f1cced5142a
    }
}