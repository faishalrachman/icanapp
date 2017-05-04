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
    public partial class TambahNilaiGuru : MetroFramework.Forms.MetroForm
    {
        int idGuru;
        List<M_Mapel> l_m = new List<M_Mapel>();
        M_Mapel mapel;
        M_Nilai nilai;
        List<M_Nilai> l_nilai = new List<M_Nilai>();
        private BindingSource bSource;

        public TambahNilaiGuru(int idGuru)
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
                string nm_mapel = db.reader.GetString("nama_mapel");
                string nm_kelas = db.reader.GetString("nama_kelas");
                M_Mapel m = new M_Mapel(kd_mapel, nm_mapel, "", "", "", "");
                l_m.Add(m);
                cbKelas.Items.Add(nm_kelas);
            }
            

        }

        void FetchNilai()
        {
            gridR.Columns.Clear();
            Database db = new Database();
            //db.reader = db.callQuery("SELECT * FROM nilai where kd_mapel = '" + l_m.ElementAt(cbKelas.SelectedIndex).KdMapel + "'");
            DataTable da = db.callQuerytoDataTable("SELECT NIS,nama FROM siswa JOIN user on(user.id = siswa.id_user) JOIN mapel using (id_kelas) where kd_mapel = '" + l_m.ElementAt(cbKelas.SelectedIndex).KdMapel + "'");
            da.Columns.Add("Skor");
            bSource = new BindingSource();
            bSource.DataSource = da;
            gridR.DataSource = bSource;
            /*


            while (db.reader.Read())
            {
                string id_nilai = db.reader.GetString("id_nilai");
                string kd_mapel = db.reader.GetString("kd_mapel");
                string NIS = db.reader.GetString("NIS");
                string nama_nilai = db.reader.GetString("nama_nilai");
                double skor = Convert.ToDouble(db.reader.GetString("skor"));
                nilai = new M_Nilai(id_nilai);
                l_nilai.Add(nilai);
                ListViewItem item = new ListViewItem(kd_mapel);//id_user
                item.SubItems.Add(nama_nilai);//ID Jadwal
                item.SubItems.Add(Convert.ToString(skor));//Jam
                tb_nilai.Items.Add(item);
            }*/
        }

        private void cbKelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            FetchNilai();
        }
    }
}
