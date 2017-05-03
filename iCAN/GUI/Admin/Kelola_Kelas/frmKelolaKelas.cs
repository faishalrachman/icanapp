using iCAN.CLASS;
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
    public partial class frmKelolaKelas : MetroFramework.Forms.MetroForm
    {
        M_Kelas kelas;
        List<M_Kelas> l_kelas = new List<M_Kelas>();
        public frmKelolaKelas()
        {
            InitializeComponent();
            Fetch();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
        void Fetch()
        {
            l_kelas.Clear();
            tb_jadwal.Clear();
            tb_jadwal.Columns.Add("Kelas",150);
            tb_jadwal.Columns.Add("Wali Kelas",150);
            Database db = new Database();
            db.reader = db.callQuery("SELECT * FROM v_kelas");
            while (db.reader.Read())
            {
                string idKelas = db.reader.GetString("id_kelas");
                string nama_kelas = db.reader.GetString("nama_kelas");
                string nama_wali = db.reader.GetString("nama");
                kelas = new M_Kelas(idKelas,nama_kelas,nama_wali);
                ListViewItem item = new ListViewItem(nama_kelas);
                item.SubItems.Add(nama_wali);
                tb_jadwal.Items.Add(item);
                l_kelas.Add(kelas);
            }
        }

        private void tb_jadwal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tb_jadwal.SelectedItems.Count > 0)
            {
                kelas = l_kelas.ElementAt(tb_jadwal.SelectedIndices[0]);
                txNamaWali.Text = kelas.Nama_wali;
                txNamaKelas.Text = kelas.Nama_kelas;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah anda yakin akan menghapus jadwal ini?", "PERINGATAN", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                kelas.deletefromDB();
                Fetch();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var form = new frmTambahKelas();
            form.ShowDialog();
            Fetch();

        }
    }
}
