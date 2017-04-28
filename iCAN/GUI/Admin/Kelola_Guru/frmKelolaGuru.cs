using System;
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
    public partial class frmKelolaGuru : MetroFramework.Forms.MetroForm
    {

        private int Selected;
        M_Guru guru;
        List<M_Guru> l_guru;
        public frmKelolaGuru()
        {

            InitializeComponent();
            l_guru = new List<M_Guru>();
            FetchUser();
        }
        void FetchUser()
        {
            l_guru.Clear();
            tb_user.Clear();
            tb_user.Columns.Add("ID User", 100);
            tb_user.Columns.Add("ID Guru", 100);
            tb_user.Columns.Add("NIP", 100);
            tb_user.Columns.Add("Nama", 100);
            tb_user.Columns.Add("Alamat", 100);
            tb_user.Columns.Add("No HP", 50);
            Database db = new Database();
            db.reader = db.callQuery("SELECT * FROM v_guru");
            while (db.reader.Read())
            {
                int id_user = Convert.ToInt32(db.reader.GetString(1));
                string id_guru = db.reader.GetString(0);
                string nip = db.reader.GetString(2);
                string nama = db.reader.GetString(3);
                string alamat = db.reader.GetString(4);
                string no_hp = db.reader.GetString(5);
                ListViewItem item = new ListViewItem(db.reader.GetString(1));//id_user
                item.SubItems.Add(db.reader.GetString(0));//ID Guru
                item.SubItems.Add(db.reader.GetString(2));//NIP
                item.SubItems.Add(db.reader.GetString(3));//nama
                item.SubItems.Add(db.reader.GetString(4));//Alamat
                item.SubItems.Add(db.reader.GetString(5));//No_hp
                guru = new M_Guru(id_user, id_guru, nip, nama, alamat, no_hp);
                l_guru.Add(guru);
                tb_user.Items.Add(item);
            }
            db.databaseConnection.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //var form = new frmTambahSiswa();
            //form.ShowDialog();
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

        private void frmKelolaGuru_Load(object sender, EventArgs e)
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
            //siswa = new M_Siswa(Selected);
            //DialogResult dialogResult = MessageBox.Show("Apakah anda yakin akan menghapus siswa ini?", "PERINGATAN", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    siswa.deleteSiswafromDB();
            //}
            FetchUser();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
