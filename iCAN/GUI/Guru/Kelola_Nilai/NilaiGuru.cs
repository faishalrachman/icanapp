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

namespace iCAN.GUI.Guru
{
    public partial class NilaiGuru : MetroFramework.Forms.MetroForm
    {
        int idGuru;
        string kd_mapel;
        List<M_Mapel> l_m = new List<M_Mapel>();
        M_Mapel mapel;
        M_Nilai nilai;
        List<M_Nilai> l_nilai = new List<M_Nilai>();
        public NilaiGuru(int idGuru)
        {
            InitializeComponent();
            this.idGuru = idGuru;
            Fetch();
        }


        void Fetch()
        {
            l_m.Clear();
            cbKelas.Items.Clear();
            Database db = new Database();
            db.reader = db.callQuery("SELECT * from mapel JOIN guru using (id_guru) JOIN kelas using (id_kelas) JOIN user on (guru.id_user=user.id) where guru.id_user = " + idGuru);
            while (db.reader.Read())
            {
                string kd_mapel = db.reader.GetString("kd_mapel");
                this.kd_mapel = kd_mapel;
                string nm_mapel = db.reader.GetString("nama_mapel");
                string nm_kelas = db.reader.GetString("nama_kelas");
                M_Mapel m = new M_Mapel(kd_mapel, nm_mapel, "", "", "", "");
                l_m.Add(m);
                cbKelas.Items.Add(nm_kelas);
            }
            tb_nilai.Clear();

        }
        void FetchNilai()
        {
            if (cbKelas.Text != "")
            {
                tb_nilai.Clear();
                tb_nilai.Columns.Add("NIS", 200);
                tb_nilai.Columns.Add("Nama Siswa", 200);
                tb_nilai.Columns.Add("Kode Mapel", 80);
                tb_nilai.Columns.Add("Nama Nilai", 200);
                tb_nilai.Columns.Add("Skor",50);
                Database db = new Database();
                db.reader = db.callQuery("SELECT * FROM nilai JOIN siswa using(NIS) JOIN user on (siswa.id_user = user.id) where kd_mapel = '" + l_m.ElementAt(cbKelas.SelectedIndex).KdMapel + "'");


                while (db.reader.Read())
                {
                    string id_nilai = db.reader.GetString("id_nilai");
                    string kd_mapel = db.reader.GetString("kd_mapel");
                    string NIS = db.reader.GetString("NIS");
                    string nama_siswa = db.reader.GetString("nama");
                    string nama_nilai = db.reader.GetString("nama_nilai");
                    double skor = Convert.ToDouble(db.reader.GetString("skor"));
                    nilai = new M_Nilai(id_nilai);
                    l_nilai.Add(nilai);
                    ListViewItem item = new ListViewItem(NIS);//id_user
                    item.SubItems.Add(nama_siswa);//ID Jadwal
                    item.SubItems.Add(kd_mapel);//ID Jadwal
                    item.SubItems.Add(nama_nilai);//ID Jadwal
                    item.SubItems.Add(Convert.ToString(skor));//Jam
                    tb_nilai.Items.Add(item);
                }
            }
        }
        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FetchNilai();
        }

        private void metroListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var f = new TambahNilaiGuru(idGuru,kd_mapel);
            f.ShowDialog();
            FetchNilai();
        }
    }
}
