namespace iCAN.GUI.Admin
{
    partial class frmKelolaJadwal
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
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txJam = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.txHari = new MetroFramework.Controls.MetroTextBox();
            this.txRuangan = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // tb_jadwal
            // 
            this.tb_jadwal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tb_jadwal.FullRowSelect = true;
            this.tb_jadwal.Location = new System.Drawing.Point(23, 167);
            this.tb_jadwal.Name = "tb_jadwal";
            this.tb_jadwal.OwnerDraw = true;
            this.tb_jadwal.Size = new System.Drawing.Size(426, 246);
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
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Jam ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 94);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(33, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Hari";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 125);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(60, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Ruangan";
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
            // txJam
            // 
            // 
            // 
            // 
            this.txJam.CustomButton.Image = null;
            this.txJam.CustomButton.Location = new System.Drawing.Point(71, 1);
            this.txJam.CustomButton.Name = "";
            this.txJam.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txJam.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txJam.CustomButton.TabIndex = 1;
            this.txJam.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txJam.CustomButton.UseSelectable = true;
            this.txJam.CustomButton.Visible = false;
            this.txJam.Lines = new string[0];
            this.txJam.Location = new System.Drawing.Point(157, 64);
            this.txJam.MaxLength = 32767;
            this.txJam.Name = "txJam";
            this.txJam.PasswordChar = '\0';
            this.txJam.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txJam.SelectedText = "";
            this.txJam.SelectionLength = 0;
            this.txJam.SelectionStart = 0;
            this.txJam.ShortcutsEnabled = true;
            this.txJam.Size = new System.Drawing.Size(160, 23);
            this.txJam.TabIndex = 5;
            this.txJam.UseSelectable = true;
            this.txJam.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txJam.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txJam.Click += new System.EventHandler(this.metroTextBox1_Click);
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
            // txHari
            // 
            // 
            // 
            // 
            this.txHari.CustomButton.Image = null;
            this.txHari.CustomButton.Location = new System.Drawing.Point(71, 1);
            this.txHari.CustomButton.Name = "";
            this.txHari.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txHari.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txHari.CustomButton.TabIndex = 1;
            this.txHari.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txHari.CustomButton.UseSelectable = true;
            this.txHari.CustomButton.Visible = false;
            this.txHari.Lines = new string[0];
            this.txHari.Location = new System.Drawing.Point(157, 94);
            this.txHari.MaxLength = 32767;
            this.txHari.Name = "txHari";
            this.txHari.PasswordChar = '\0';
            this.txHari.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txHari.SelectedText = "";
            this.txHari.SelectionLength = 0;
            this.txHari.SelectionStart = 0;
            this.txHari.ShortcutsEnabled = true;
            this.txHari.Size = new System.Drawing.Size(160, 23);
            this.txHari.TabIndex = 7;
            this.txHari.UseSelectable = true;
            this.txHari.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txHari.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txRuangan
            // 
            // 
            // 
            // 
            this.txRuangan.CustomButton.Image = null;
            this.txRuangan.CustomButton.Location = new System.Drawing.Point(71, 1);
            this.txRuangan.CustomButton.Name = "";
            this.txRuangan.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txRuangan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txRuangan.CustomButton.TabIndex = 1;
            this.txRuangan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txRuangan.CustomButton.UseSelectable = true;
            this.txRuangan.CustomButton.Visible = false;
            this.txRuangan.Lines = new string[0];
            this.txRuangan.Location = new System.Drawing.Point(157, 125);
            this.txRuangan.MaxLength = 32767;
            this.txRuangan.Name = "txRuangan";
            this.txRuangan.PasswordChar = '\0';
            this.txRuangan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txRuangan.SelectedText = "";
            this.txRuangan.SelectionLength = 0;
            this.txRuangan.SelectionStart = 0;
            this.txRuangan.ShortcutsEnabled = true;
            this.txRuangan.Size = new System.Drawing.Size(160, 23);
            this.txRuangan.TabIndex = 8;
            this.txRuangan.UseSelectable = true;
            this.txRuangan.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txRuangan.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmKelolaJadwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 472);
            this.Controls.Add(this.txRuangan);
            this.Controls.Add(this.txHari);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.txJam);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tb_jadwal);
            this.Name = "frmKelolaJadwal";
            this.ShowIcon = false;
            this.Text = "Kelola Jadwal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroListView tb_jadwal;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txJam;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox txHari;
        private MetroFramework.Controls.MetroTextBox txRuangan;
    }
}