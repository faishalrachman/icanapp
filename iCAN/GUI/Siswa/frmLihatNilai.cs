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
            
        }
    }
}
