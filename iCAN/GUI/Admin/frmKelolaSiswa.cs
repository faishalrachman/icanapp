using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCAN.GUI.Admin
{
    public partial class frmKelolaSiswa : MetroFramework.Forms.MetroForm
    {
        private int Selected;
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
                ListViewItem item = new ListViewItem(db.reader.GetString(1));//id_user
                item.SubItems.Add(db.reader.GetString(0));//nis
                item.SubItems.Add(db.reader.GetString(2));//nama
                item.SubItems.Add(db.reader.GetString(4));//kelas
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
                MessageBox.Show(Selected.ToString());
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
            Database db = new Database();
            DialogResult dialogResult = MessageBox.Show("Apakah anda yakin akan menghapus siswa ini?", "PERINGATAN", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool i = db.CallnonQuery("DELETE FROM user WHERE id = " + Selected);
                if (i)
                {
                    i = db.CallnonQuery("DELETE FROM siswa WHERE id_user = " + Selected);
                    if (i)
                        MessageBox.Show("Success");
                }
            }
            FetchUser();

        }
    }
}
