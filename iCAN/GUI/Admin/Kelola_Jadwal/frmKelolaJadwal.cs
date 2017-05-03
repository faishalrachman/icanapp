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
    public partial class frmKelolaJadwal : MetroFramework.Forms.MetroForm
    {
        M_Jadwal jadwal;
        List<M_Jadwal> l_jadwal = new List<M_Jadwal>();
        public frmKelolaJadwal()
        {
            InitializeComponent();
            Fetch();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
        void Fetch()
        {
            l_jadwal.Clear();
            tb_jadwal.Clear();
            tb_jadwal.Columns.Add("Jam",150);
            tb_jadwal.Columns.Add("Hari");
            tb_jadwal.Columns.Add("Ruangan", 200);
            Database db = new Database();
            db.reader = db.callQuery("SELECT * FROM jadwal");
            while (db.reader.Read())
            {
                string idJadwal = db.reader.GetString("id_jadwal");
                string jam = db.reader.GetString("jam");
                string hari = db.reader.GetString("hari");
                string ruangan = db.reader.GetString("ruangan");
                jadwal = new M_Jadwal(idJadwal, jam, hari, ruangan);
                l_jadwal.Add(jadwal);
                ListViewItem item = new ListViewItem(jam);//id_user
                item.SubItems.Add(hari);//nis
                item.SubItems.Add(ruangan);//nis
                tb_jadwal.Items.Add(item);
            }
        }

        private void tb_jadwal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tb_jadwal.SelectedItems.Count > 0)
            {
                jadwal = l_jadwal.ElementAt(tb_jadwal.SelectedIndices[0]);
                txHari.Text = jadwal.Hari;
                txJam.Text = jadwal.Jam;
                txRuangan.Text = jadwal.Ruangan;

            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah anda yakin akan menghapus jadwal ini?", "PERINGATAN", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                jadwal.deletefromDB();
                Fetch();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            jadwal = new M_Jadwal(txJam.Text, txHari.Text, txRuangan.Text);
            MessageBox.Show("Add Jadwal Sukses");
            Fetch();
        }
    }
}
