namespace iCAN.GUI.Admin
{
    partial class frmKelolaBerita
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
            this.cbOpsiJudul = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txInputJudul = new MetroFramework.Controls.MetroTextBox();
            this.txIsi = new MetroFramework.Controls.MetroTextBox();
            this.btTambahBerita = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.btBatal = new MetroFramework.Controls.MetroButton();
            this.btDelete = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // cbOpsiJudul
            // 
            this.cbOpsiJudul.FormattingEnabled = true;
            this.cbOpsiJudul.ItemHeight = 23;
            this.cbOpsiJudul.Location = new System.Drawing.Point(23, 82);
            this.cbOpsiJudul.Name = "cbOpsiJudul";
            this.cbOpsiJudul.Size = new System.Drawing.Size(436, 29);
            this.cbOpsiJudul.TabIndex = 0;
            this.cbOpsiJudul.UseSelectable = true;
            this.cbOpsiJudul.SelectedIndexChanged += new System.EventHandler(this.cbOpsiJudul_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Judul Berita :";
            // 
            // txInputJudul
            // 
            // 
            // 
            // 
            this.txInputJudul.CustomButton.Image = null;
            this.txInputJudul.CustomButton.Location = new System.Drawing.Point(411, 1);
            this.txInputJudul.CustomButton.Name = "";
            this.txInputJudul.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txInputJudul.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txInputJudul.CustomButton.TabIndex = 1;
            this.txInputJudul.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txInputJudul.CustomButton.UseSelectable = true;
            this.txInputJudul.CustomButton.Visible = false;
            this.txInputJudul.Lines = new string[0];
            this.txInputJudul.Location = new System.Drawing.Point(23, 83);
            this.txInputJudul.MaxLength = 32767;
            this.txInputJudul.Name = "txInputJudul";
            this.txInputJudul.PasswordChar = '\0';
            this.txInputJudul.PromptText = "Input Judul Disini";
            this.txInputJudul.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txInputJudul.SelectedText = "";
            this.txInputJudul.SelectionLength = 0;
            this.txInputJudul.SelectionStart = 0;
            this.txInputJudul.ShortcutsEnabled = true;
            this.txInputJudul.ShowClearButton = true;
            this.txInputJudul.Size = new System.Drawing.Size(439, 29);
            this.txInputJudul.TabIndex = 4;
            this.txInputJudul.UseSelectable = true;
            this.txInputJudul.Visible = false;
            this.txInputJudul.WaterMark = "Input Judul Disini";
            this.txInputJudul.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txInputJudul.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txIsi
            // 
            // 
            // 
            // 
            this.txIsi.CustomButton.Image = null;
            this.txIsi.CustomButton.Location = new System.Drawing.Point(38, 2);
            this.txIsi.CustomButton.Name = "";
            this.txIsi.CustomButton.Size = new System.Drawing.Size(397, 397);
            this.txIsi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txIsi.CustomButton.TabIndex = 1;
            this.txIsi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txIsi.CustomButton.UseSelectable = true;
            this.txIsi.CustomButton.Visible = false;
            this.txIsi.Lines = new string[0];
            this.txIsi.Location = new System.Drawing.Point(24, 137);
            this.txIsi.MaxLength = 32767;
            this.txIsi.Multiline = true;
            this.txIsi.Name = "txIsi";
            this.txIsi.PasswordChar = '\0';
            this.txIsi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txIsi.SelectedText = "";
            this.txIsi.SelectionLength = 0;
            this.txIsi.SelectionStart = 0;
            this.txIsi.ShortcutsEnabled = true;
            this.txIsi.Size = new System.Drawing.Size(438, 402);
            this.txIsi.TabIndex = 5;
            this.txIsi.UseSelectable = true;
            this.txIsi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txIsi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btTambahBerita
            // 
            this.btTambahBerita.Location = new System.Drawing.Point(47, 550);
            this.btTambahBerita.Name = "btTambahBerita";
            this.btTambahBerita.Size = new System.Drawing.Size(75, 23);
            this.btTambahBerita.TabIndex = 6;
            this.btTambahBerita.Text = "Add";
            this.btTambahBerita.UseSelectable = true;
            this.btTambahBerita.Click += new System.EventHandler(this.metroButton2_Click_1);
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(204, 550);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(75, 23);
            this.metroButton5.TabIndex = 3;
            this.metroButton5.Text = "Save";
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // btBatal
            // 
            this.btBatal.Enabled = false;
            this.btBatal.Location = new System.Drawing.Point(204, 589);
            this.btBatal.Name = "btBatal";
            this.btBatal.Size = new System.Drawing.Size(75, 23);
            this.btBatal.TabIndex = 7;
            this.btBatal.Text = "Cancel";
            this.btBatal.UseSelectable = true;
            this.btBatal.Click += new System.EventHandler(this.btBatal_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(354, 550);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 7;
            this.btDelete.Text = "Delete";
            this.btDelete.UseSelectable = true;
            this.btDelete.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // frmKelolaBerita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 624);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btBatal);
            this.Controls.Add(this.btTambahBerita);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.txIsi);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbOpsiJudul);
            this.Controls.Add(this.txInputJudul);
            this.MaximizeBox = false;
            this.Name = "frmKelolaBerita";
            this.Text = "Kelola Berita";
            this.Load += new System.EventHandler(this.frmKelolaBerita_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbOpsiJudul;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txInputJudul;
        private MetroFramework.Controls.MetroTextBox txIsi;
        private MetroFramework.Controls.MetroButton btTambahBerita;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton btBatal;
        private MetroFramework.Controls.MetroButton btDelete;
    }
}