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
    public partial class frmKelolaBerita : MetroFramework.Forms.MetroForm
    {
        M_Berita berita;
        List<M_Berita> l_berita;
        public frmKelolaBerita()
        {
            InitializeComponent();
            FetchNews();
        }
        void FetchNews()
        {
            txIsi.Text = "";
            txInputJudul.Text = "";
            l_berita = new List<M_Berita>();
            Database db = new Database();
            cbOpsiJudul.Items.Clear();
            db.reader = db.callQuery("SELECT * FROM berita");
            while (db.reader.Read())
            {
                //1                Kemahalan Harga KTM                KTM jadi mahal euy 1
                int idNews = Convert.ToInt32(db.reader.GetString(0));
                string judul = db.reader.GetString(1);
                string isi = db.reader.GetString(2);
                berita = new M_Berita(idNews, judul, isi);
                l_berita.Add(berita);
                cbOpsiJudul.Items.Add(db.reader.GetString(1));
            }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
        }

        private void tb_user_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmKelolaBerita_Load(object sender, EventArgs e)
        {
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }


        private void metroButton4_Click(object sender, EventArgs e)
        {

        }

        private void cbOpsiJudul_SelectedIndexChanged(object sender, EventArgs e)
        {
            txIsi.Text = l_berita.ElementAt(cbOpsiJudul.SelectedIndex).isi;
            berita = l_berita.ElementAt(cbOpsiJudul.SelectedIndex);
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            cbOpsiJudul.Visible = false;
            txInputJudul.Visible = true;
            btDelete.Enabled = false;
            btBatal.Enabled = true;
            FetchNews();
            berita = null;
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            string judul = txInputJudul.Text;
            string isi = txIsi.Text;

            if (berita != null)
            {
                berita.isi = isi;
                berita.saveBeritatoDB();
            }
            else
            {
                berita = new M_Berita(judul, isi);
            }
            txIsi.Text = "";
            btDelete.Enabled = true;
            btBatal.Enabled = false;
            txInputJudul.Visible = false;
            cbOpsiJudul.Visible = true;
            FetchNews();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Apakah anda yakin akan menghapus berita ini?", "PERINGATAN", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                berita = l_berita.ElementAt(cbOpsiJudul.SelectedIndex);
                berita.deleteBeritafromDB();
            }

            FetchNews();
        }

        private void btBatal_Click(object sender, EventArgs e)
        {
            cbOpsiJudul.Visible = true;
            txInputJudul.Visible = false;
            txIsi.Text = "";

        }
    }
}
