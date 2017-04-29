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
    public partial class frmTambahMapel : MetroFramework.Forms.MetroForm
    {
        M_Mapel mapel;
        List<M_Mapel> l_mapel;
        public frmTambahMapel()
        {
            InitializeComponent();
            FetchMapel();
        }
        void FetchMapel()
        {
            //txIsi.Text = "";
            //txInputJudul.Text = "";
            //l_berita = new List<M_Berita>();
            //Database db = new Database();
            //cbOpsiJudul.Items.Clear();
            //db.reader = db.callQuery("SELECT * FROM v_mapel");
            //while (db.reader.Read())
            //{
            //    //1                Kemahalan Harga KTM                KTM jadi mahal euy 1
            //    int idNews = Convert.ToInt32(db.reader.GetString(0));
            //    string judul = db.reader.GetString(1);
            //    string isi = db.reader.GetString(2);
            //    berita = new M_Berita(idNews, judul, isi);
            //    l_berita.Add(berita);
            //    cbOpsiJudul.Items.Add(db.reader.GetString(1));
            //    //id_jadwal id_kelas    id_guru id_mapel    nama_mapel id_user     NIP nama    jam hari    ruangan

            Database db = new Database();
            db.reader = db.callQuery("SELECT * FROM v_mapel");
            while (db.reader.Read())
            {

            }
        }

        private void frmTambahMapel_Load(object sender, EventArgs e)
        {

        }
    }
    
}
