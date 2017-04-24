namespace iCAN.GUI
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.cbUsername = new MetroFramework.Controls.MetroCheckBox();
            this.txUsername = new MetroFramework.Controls.MetroTextBox();
            this.txPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(332, 352);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(135, 37);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Login";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.login_Clicked);
            // 
            // cbUsername
            // 
            this.cbUsername.AutoSize = true;
            this.cbUsername.Location = new System.Drawing.Point(262, 309);
            this.cbUsername.Name = "cbUsername";
            this.cbUsername.Size = new System.Drawing.Size(106, 15);
            this.cbUsername.TabIndex = 1;
            this.cbUsername.Text = "Ingat Username";
            this.cbUsername.UseSelectable = true;
            this.cbUsername.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // txUsername
            // 
            // 
            // 
            // 
            this.txUsername.CustomButton.Image = null;
            this.txUsername.CustomButton.Location = new System.Drawing.Point(293, 1);
            this.txUsername.CustomButton.Name = "";
            this.txUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txUsername.CustomButton.TabIndex = 1;
            this.txUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txUsername.CustomButton.UseSelectable = true;
            this.txUsername.CustomButton.Visible = false;
            this.txUsername.Lines = new string[0];
            this.txUsername.Location = new System.Drawing.Point(262, 223);
            this.txUsername.MaxLength = 32767;
            this.txUsername.Name = "txUsername";
            this.txUsername.PasswordChar = '\0';
            this.txUsername.PromptText = "Username";
            this.txUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txUsername.SelectedText = "";
            this.txUsername.SelectionLength = 0;
            this.txUsername.SelectionStart = 0;
            this.txUsername.ShortcutsEnabled = true;
            this.txUsername.Size = new System.Drawing.Size(315, 23);
            this.txUsername.TabIndex = 2;
            this.txUsername.UseSelectable = true;
            this.txUsername.WaterMark = "Username";
            this.txUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txPassword
            // 
            // 
            // 
            // 
            this.txPassword.CustomButton.Image = null;
            this.txPassword.CustomButton.Location = new System.Drawing.Point(293, 1);
            this.txPassword.CustomButton.Name = "";
            this.txPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txPassword.CustomButton.TabIndex = 1;
            this.txPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txPassword.CustomButton.UseSelectable = true;
            this.txPassword.CustomButton.Visible = false;
            this.txPassword.Lines = new string[0];
            this.txPassword.Location = new System.Drawing.Point(262, 269);
            this.txPassword.MaxLength = 32767;
            this.txPassword.Name = "txPassword";
            this.txPassword.PasswordChar = '*';
            this.txPassword.PromptText = "Password";
            this.txPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txPassword.SelectedText = "";
            this.txPassword.SelectionLength = 0;
            this.txPassword.SelectionStart = 0;
            this.txPassword.ShortcutsEnabled = true;
            this.txPassword.Size = new System.Drawing.Size(315, 23);
            this.txPassword.TabIndex = 3;
            this.txPassword.UseSelectable = true;
            this.txPassword.WaterMark = "Password";
            this.txPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLink1
            // 
            this.metroLink1.DisplayFocus = true;
            this.metroLink1.Image = ((System.Drawing.Image)(resources.GetObject("metroLink1.Image")));
            this.metroLink1.ImageSize = 100;
            this.metroLink1.Location = new System.Drawing.Point(325, 63);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(145, 157);
            this.metroLink1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLink1.TabIndex = 4;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroLink1_MouseClick);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 502);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.txPassword);
            this.Controls.Add(this.txUsername);
            this.Controls.Add(this.cbUsername);
            this.Controls.Add(this.metroButton1);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroCheckBox cbUsername;
        private MetroFramework.Controls.MetroTextBox txUsername;
        private MetroFramework.Controls.MetroTextBox txPassword;
        private MetroFramework.Controls.MetroLink metroLink1;
    }
}