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

namespace iCAN.GUI.Siswa
{
    public partial class frmLihatNilai : MetroFramework.Forms.MetroForm
      

    {
        M_Siswa siswa;
        public frmLihatNilai(int idUser)
        {
            InitializeComponent();
<<<<<<< HEAD
            siswa = new M_Siswa(idUser);
            fetchNilai();
        }

        void fetchNilai()
        {
            listNilai.Clear();
            listNilai.Columns.Add("NIS",100);
            listNilai.Columns.Add("kode mapel",100);
            listNilai.Columns.Add("nama nilai",100);
            listNilai.Columns.Add("skor ",100);
            Database db = new Database();
            string query = "Select * from nilai where NIS = '" + siswa.myNIS + "'";
            db.reader = db.callQuery(query);
            while (db.reader.Read())
            {
                string kd_mapel = db.reader.GetString("kd_mapel");
                string NIS = db.reader.GetString("NIS");
                string nama_nilai = db.reader.GetString("nama_nilai");
                double skor = Convert.ToDouble(db.reader.GetString("skor"));
                ListViewItem item = new ListViewItem(NIS);//NIS
                item.SubItems.Add(kd_mapel);//kd_mapel
                item.SubItems.Add(nama_nilai);//nama_nilai
                item.SubItems.Add(Convert.ToString(skor));//skor

                listNilai.Items.Add(item);
=======
            Fetch();
        }

        private void Fetch()
        {
            metroListNilai.Clear();
            metroListNilai.Columns.Add("Kode Mapel", 100);
            metroListNilai.Columns.Add("Nama Mapel", 100);
            metroListNilai.Columns.Add("Jenis Nilai", 100);
            metroListNilai.Columns.Add("Skor", 100);



            Database db = new Database();
            db.reader = db.callQuery("SELECT * FROM v_nilai");
            while (db.reader.Read())
            {

                string kd_mapel = db.reader.GetString("kd_mapel");
                string namamapel = db.reader.GetString("nama_mapel");
                string jenisnilai = db.reader.GetString("nama_nilai");
                string skor = db.reader.GetString("skor");
                

                ListViewItem item = new ListViewItem(db.reader.GetString("id_user"));
                item.SubItems.Add(db.reader.GetString("kd_mapel"));//ID Jadwal
                item.SubItems.Add(db.reader.GetString("nama_mapel"));//Jam
                item.SubItems.Add(db.reader.GetString("nama_nilai"));//hari
                item.SubItems.Add(db.reader.GetString("skor"));//Ruangan
                

                metroListNilai.Items.Add(item);
>>>>>>> e97259a59ee2e7786031b49f9f1f6f1cced5142a

            }
            db.databaseConnection.Close();
        }

        private void frmLihatNilai_Load(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            
=======

>>>>>>> e97259a59ee2e7786031b49f9f1f6f1cced5142a
        }
    }
}
