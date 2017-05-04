namespace iCAN.GUI.Guru
{
    partial class TambahNilaiGuru
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbKelas = new MetroFramework.Controls.MetroComboBox();
            this.gridR = new MetroFramework.Controls.MetroGrid();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txJenisNilai = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridR)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(25, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 25);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Pilih Kelas";
            // 
            // cbKelas
            // 
            this.cbKelas.FormattingEnabled = true;
            this.cbKelas.ItemHeight = 23;
            this.cbKelas.Location = new System.Drawing.Point(118, 63);
            this.cbKelas.Name = "cbKelas";
            this.cbKelas.Size = new System.Drawing.Size(121, 29);
            this.cbKelas.TabIndex = 4;
            this.cbKelas.UseSelectable = true;
            this.cbKelas.SelectedIndexChanged += new System.EventHandler(this.cbKelas_SelectedIndexChanged);
            // 
            // gridR
            // 
            this.gridR.AllowUserToAddRows = false;
            this.gridR.AllowUserToDeleteRows = false;
            this.gridR.AllowUserToResizeRows = false;
            this.gridR.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridR.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridR.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridR.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nama,
            this.Idung});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridR.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridR.EnableHeadersVisualStyles = false;
            this.gridR.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridR.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridR.Location = new System.Drawing.Point(25, 110);
            this.gridR.Name = "gridR";
            this.gridR.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridR.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridR.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridR.Size = new System.Drawing.Size(535, 275);
            this.gridR.StandardTab = true;
            this.gridR.TabIndex = 6;
            // 
            // nama
            // 
            this.nama.HeaderText = "Column1";
            this.nama.Name = "nama";
            // 
            // Idung
            // 
            this.Idung.HeaderText = "Column1";
            this.Idung.Name = "Idung";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(288, 72);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Jenis Nilai :";
            // 
            // txJenisNilai
            // 
            // 
            // 
            // 
            this.txJenisNilai.CustomButton.Image = null;
            this.txJenisNilai.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.txJenisNilai.CustomButton.Name = "";
            this.txJenisNilai.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txJenisNilai.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txJenisNilai.CustomButton.TabIndex = 1;
            this.txJenisNilai.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txJenisNilai.CustomButton.UseSelectable = true;
            this.txJenisNilai.CustomButton.Visible = false;
            this.txJenisNilai.Lines = new string[0];
            this.txJenisNilai.Location = new System.Drawing.Point(365, 70);
            this.txJenisNilai.MaxLength = 32767;
            this.txJenisNilai.Name = "txJenisNilai";
            this.txJenisNilai.PasswordChar = '\0';
            this.txJenisNilai.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txJenisNilai.SelectedText = "";
            this.txJenisNilai.SelectionLength = 0;
            this.txJenisNilai.SelectionStart = 0;
            this.txJenisNilai.ShortcutsEnabled = true;
            this.txJenisNilai.Size = new System.Drawing.Size(195, 23);
            this.txJenisNilai.TabIndex = 8;
            this.txJenisNilai.UseSelectable = true;
            this.txJenisNilai.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txJenisNilai.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(243, 391);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 9;
            this.metroButton1.Text = "Tambah";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // TambahNilaiGuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 420);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txJenisNilai);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.gridR);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbKelas);
            this.Name = "TambahNilaiGuru";
            this.Text = "Input Nilai";
            ((System.ComponentModel.ISupportInitialize)(this.gridR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbKelas;
        private MetroFramework.Controls.MetroGrid gridR;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idung;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txJenisNilai;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}