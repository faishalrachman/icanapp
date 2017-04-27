namespace iCAN.GUI.Admin
{
    partial class frmEditAdmin
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
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(134, 231);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Ubah";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(71, 231);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(57, 23);
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
            this.txUsername.Enabled = false;
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
            this.metroLabel2.Location = new System.Drawing.Point(30, 126);
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
            this.txPassword.CustomButton.Visible = false;
            this.txPassword.Lines = new string[0];
            this.txPassword.Location = new System.Drawing.Point(29, 149);
            this.txPassword.MaxLength = 32767;
            this.txPassword.Name = "txPassword";
            this.txPassword.PasswordChar = '\0';
            this.txPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txPassword.SelectedText = "";
            this.txPassword.SelectionLength = 0;
            this.txPassword.SelectionStart = 0;
            this.txPassword.ShortcutsEnabled = true;
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
            this.txNama.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.txNama.CustomButton.Name = "";
            this.txNama.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txNama.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txNama.CustomButton.TabIndex = 1;
            this.txNama.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txNama.CustomButton.UseSelectable = true;
            this.txNama.CustomButton.Visible = false;
            this.txNama.Lines = new string[0];
            this.txNama.Location = new System.Drawing.Point(27, 202);
            this.txNama.MaxLength = 32767;
            this.txNama.Name = "txNama";
            this.txNama.PasswordChar = '\0';
            this.txNama.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txNama.SelectedText = "";
            this.txNama.SelectionLength = 0;
            this.txNama.SelectionStart = 0;
            this.txNama.ShortcutsEnabled = true;
            this.txNama.Size = new System.Drawing.Size(182, 23);
            this.txNama.TabIndex = 7;
            this.txNama.UseSelectable = true;
            this.txNama.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txNama.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(30, 179);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Nama";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(25, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 2);
            this.label1.TabIndex = 9;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmEditAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(244, 281);
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
            this.Name = "frmEditAdmin";
            this.Resizable = false;
            this.Text = "Ubah Admin";
            this.Load += new System.EventHandler(this.frmEditAdmin_Load);
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
    }
}