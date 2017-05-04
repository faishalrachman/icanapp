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
        public frmLihatNilai()
        {
            InitializeComponent();
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
