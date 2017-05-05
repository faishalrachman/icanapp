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
            siswa = new M_Siswa(idUser);
            fetchNilai();
        }

        void fetchNilai()
        {
            listNilai.Clear();
            listNilai.Columns.Add("NIS");
            listNilai.Columns.Add("kode mapel");
            listNilai.Columns.Add("nama nilai");
            listNilai.Columns.Add("skor ");
            Database db = new Database();
            string query = "Select * from nilai where NIS = " + siswa.myNIS;
            db.reader = db.callQuery(query);
            while (db.reader.Read())
            {
                string kd_mapel = db.reader.GetString("kd_mapel");
                string NIS = db.reader.GetString("NIS");
                string nama_nilai = db.reader.GetString("nama_nilai");
                double skor = Convert.ToDouble(db.reader.GetString("skor"));
                ListViewItem item = new ListViewItem(NIS);//id_user
                item.SubItems.Add(kd_mapel);//ID Jadwal
                item.SubItems.Add(nama_nilai);//ID Jadwal
                item.SubItems.Add(Convert.ToString(skor));//Jam
                
            }
        }

        private void frmLihatNilai_Load(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
