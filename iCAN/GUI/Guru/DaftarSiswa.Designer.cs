namespace iCAN.GUI.Guru
{
    partial class DaftarSiswa
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.selectkelas = new MetroFramework.Controls.MetroComboBox();
            this.listViewSiswa = new MetroFramework.Controls.MetroListView();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(264, 75);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(77, 29);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Pilih";
            this.metroButton1.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(32, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 25);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Pilih Kelas";
            // 
            // selectkelas
            // 
            this.selectkelas.FormattingEnabled = true;
            this.selectkelas.ItemHeight = 23;
            this.selectkelas.Location = new System.Drawing.Point(125, 75);
            this.selectkelas.Name = "selectkelas";
            this.selectkelas.Size = new System.Drawing.Size(121, 29);
            this.selectkelas.TabIndex = 6;
            this.selectkelas.UseSelectable = true;
            this.selectkelas.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // listViewSiswa
            // 
            this.listViewSiswa.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewSiswa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listViewSiswa.FullRowSelect = true;
            this.listViewSiswa.GridLines = true;
            this.listViewSiswa.HotTracking = true;
            this.listViewSiswa.HoverSelection = true;
            this.listViewSiswa.LabelEdit = true;
            this.listViewSiswa.Location = new System.Drawing.Point(32, 124);
            this.listViewSiswa.Name = "listViewSiswa";
            this.listViewSiswa.OwnerDraw = true;
            this.listViewSiswa.Size = new System.Drawing.Size(744, 287);
            this.listViewSiswa.TabIndex = 9;
            this.listViewSiswa.UseCompatibleStateImageBehavior = false;
            this.listViewSiswa.UseSelectable = true;
            this.listViewSiswa.View = System.Windows.Forms.View.Details;
            this.listViewSiswa.SelectedIndexChanged += new System.EventHandler(this.listViewSiswa_SelectedIndexChanged);
            // 
            // DaftarSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 434);
            this.Controls.Add(this.listViewSiswa);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.selectkelas);
            this.Name = "DaftarSiswa";
            this.Text = "Daftar Siswa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox selectkelas;
        private MetroFramework.Controls.MetroListView listViewSiswa;
    }
}