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
        List<M_Guru> l_guru = new List<M_Guru>();
        List<M_Kelas> l_kelas = new List<M_Kelas>();
        M_Kelas kelas;
        M_Guru guru;
        M_Jadwal jadwal;
        List<M_Jadwal> l_jadwal = new List<M_Jadwal>();
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
            l_guru.Clear();
            l_jadwal.Clear();
            Database db = new Database();
            db.reader = db.callQuery("SELECT * FROM v_guru");
            cbNamaGuru.Items.Clear();
            cbKelas.Items.Clear();
            cbJadwal.Items.Clear();
            while (db.reader.Read())
            {
        //public M_Guru(int idUser, String idGuru, string nip, string nama, string alamat, string no_hp)
                String id_guru = db.reader.GetString("id_guru");
                int idUser = Convert.ToInt32(db.reader.GetString("id_user"));
                string nip = db.reader.GetString("NIP");
                string nama = db.reader.GetString("nama");
                string alamat = db.reader.GetString("alamat");
                string no_hp = db.reader.GetString("no_hp");
                guru = new M_Guru(idUser,id_guru,nip,nama,alamat,no_hp);
                l_guru.Add(guru);
                cbNamaGuru.Items.Add(guru.Nama);
            }
            db.reader = db.callQuery("SELECT * from jadwal");
            while (db.reader.Read())
            {
                string idJadwal = db.reader.GetString("id_jadwal");
                string jam = db.reader.GetString("jam");
                string ruangan = db.reader.GetString("ruangan");
                string hari = db.reader.GetString("hari");
                jadwal = new M_Jadwal(idJadwal, jam, hari, ruangan);
                l_jadwal.Add(jadwal);
                cbJadwal.Items.Add(jadwal.Hari + ", " + jadwal.Jam);
            }

            db.reader = db.callQuery("SELECT * from v_kelas");
            while (db.reader.Read())
            {
                string idKelas = db.reader.GetString("id_kelas");
                string nama_kelas = db.reader.GetString("nama_kelas");
                string nama_wali = db.reader.GetString("nama");
                kelas = new M_Kelas(idKelas, nama_kelas, nama_wali);
                l_kelas.Add(kelas);
                cbKelas.Items.Add(kelas.Nama_kelas);
            }

        }

        private void frmTambahMapel_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string kd_mapel = txkdMapel.Text;
            string nama_mapel = txNamaMapel.Text;
            string id_jadwal = l_jadwal.ElementAt(cbJadwal.SelectedIndex).getId();
            string id_guru = l_guru.ElementAt(cbNamaGuru.SelectedIndex).IdGuru;
            string id_kelas = l_guru.ElementAt(cbNamaGuru.SelectedIndex).IdGuru;
            Database db = new Database();
            bool i = db.CallnonQuery("INSERT INTO mapel(kd_mapel,nama_mapel,id_guru,id_kelas,id_jadwal) VALUES ('"+kd_mapel+"', '"+nama_mapel+"',"+id_guru+","+id_kelas+","+id_jadwal+")");
            if (i){
                MessageBox.Show("Success");
            }
        }
    }
    
}
