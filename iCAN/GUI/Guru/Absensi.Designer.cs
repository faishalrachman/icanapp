namespace iCAN.GUI.Guru
{
    partial class Absensi
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.PilihKelas = new MetroFramework.Controls.MetroLabel();
            this.btnPilihKelas = new MetroFramework.Controls.MetroButton();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroScrollBar1 = new MetroFramework.Controls.MetroScrollBar();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.Nama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NIS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kehadiran = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.PilihKelas);
            this.metroPanel1.Controls.Add(this.btnPilihKelas);
            this.metroPanel1.Controls.Add(this.metroComboBox1);
            this.metroPanel1.Controls.Add(this.metroScrollBar1);
            this.metroPanel1.Controls.Add(this.metroListView1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(804, 450);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // PilihKelas
            // 
            this.PilihKelas.AutoSize = true;
            this.PilihKelas.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.PilihKelas.Location = new System.Drawing.Point(28, 26);
            this.PilihKelas.Name = "PilihKelas";
            this.PilihKelas.Size = new System.Drawing.Size(87, 25);
            this.PilihKelas.TabIndex = 6;
            this.PilihKelas.Text = "Pilih Kelas";
            // 
            // btnPilihKelas
            // 
            this.btnPilihKelas.Location = new System.Drawing.Point(317, 22);
            this.btnPilihKelas.Name = "btnPilihKelas";
            this.btnPilihKelas.Size = new System.Drawing.Size(75, 29);
            this.btnPilihKelas.TabIndex = 5;
            this.btnPilihKelas.Text = "PilihKelas";
            this.btnPilihKelas.UseSelectable = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(121, 22);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(190, 29);
            this.metroComboBox1.TabIndex = 4;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroScrollBar1
            // 
            this.metroScrollBar1.LargeChange = 10;
            this.metroScrollBar1.Location = new System.Drawing.Point(781, 80);
            this.metroScrollBar1.Maximum = 100;
            this.metroScrollBar1.Minimum = 0;
            this.metroScrollBar1.MouseWheelBarPartitions = 10;
            this.metroScrollBar1.Name = "metroScrollBar1";
            this.metroScrollBar1.Orientation = MetroFramework.Controls.MetroScrollOrientation.Vertical;
            this.metroScrollBar1.ScrollbarSize = 10;
            this.metroScrollBar1.Size = new System.Drawing.Size(10, 352);
            this.metroScrollBar1.TabIndex = 3;
            this.metroScrollBar1.UseSelectable = true;
            this.metroScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroScrollBar1_Scroll);
            // 
            // metroListView1
            // 
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nama,
            this.NIS,
            this.Kehadiran});
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.GridLines = true;
            this.metroListView1.Location = new System.Drawing.Point(14, 80);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(777, 352);
            this.metroListView1.TabIndex = 2;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.SelectedIndexChanged += new System.EventHandler(this.metroListView1_SelectedIndexChanged);
            // 
            // Nama
            // 
            this.Nama.Text = "Nama Siswa";
            // 
            // NIS
            // 
            this.NIS.Text = "NIS";
            this.NIS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Kehadiran
            // 
            this.Kehadiran.Text = "Kehadiran Siswa";
            // 
            // Absensi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 536);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Absensi";
            this.Text = "Absensi";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroListView metroListView1;
        private System.Windows.Forms.ColumnHeader Nama;
        private System.Windows.Forms.ColumnHeader NIS;
        private System.Windows.Forms.ColumnHeader Kehadiran;
        private MetroFramework.Controls.MetroScrollBar metroScrollBar1;
        private MetroFramework.Controls.MetroLabel PilihKelas;
        private MetroFramework.Controls.MetroButton btnPilihKelas;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
    }
}