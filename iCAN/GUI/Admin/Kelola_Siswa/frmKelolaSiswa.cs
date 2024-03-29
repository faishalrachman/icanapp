﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iCAN.CLASS;

namespace iCAN.GUI.Admin
{
    public partial class frmKelolaSiswa : MetroFramework.Forms.MetroForm
    {
        
        private int Selected;
        M_Siswa siswa;
        public frmKelolaSiswa()
        {

            InitializeComponent();
            FetchUser();
        }
        void FetchUser()
        {
            tb_user.Clear();
            tb_user.Columns.Add("ID User", 50);
            tb_user.Columns.Add("NIS", 100);
            tb_user.Columns.Add("Nama", 100);
            tb_user.Columns.Add("Kelas", 100);
            Database db = new Database();
            db.reader = db.callQuery("SELECT * FROM v_siswa");
            while (db.reader.Read())
            {
                ListViewItem item = new ListViewItem(db.reader.GetString("id_user"));//id_user
                item.SubItems.Add(db.reader.GetString("NIS"));//nis
                item.SubItems.Add(db.reader.GetString("nama"));//nama
                item.SubItems.Add(db.reader.GetString("nama_kelas"));//kelas
                tb_user.Items.Add(item);
            }
            db.databaseConnection.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var form = new frmTambahSiswa();
            form.ShowDialog();
            FetchUser();
        }

        private void tb_user_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tb_user.SelectedIndices.Count > 0)
            {
                Selected = Convert.ToInt32(tb_user.SelectedItems[0].SubItems[0].Text);
                metroButton2.Enabled = true;
                metroButton3.Enabled = true;
            }
        }

        private void frmKelolaSiswa_Load(object sender, EventArgs e)
        {
            tb_user.MultiSelect = false;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var form = new frmEditSiswa(Selected);
            form.ShowDialog();
            FetchUser();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            siswa = new M_Siswa(Selected);
            DialogResult dialogResult = MessageBox.Show("Apakah anda yakin akan menghapus siswa ini?", "PERINGATAN", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                siswa.deleteSiswafromDB();
            }
            FetchUser();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
