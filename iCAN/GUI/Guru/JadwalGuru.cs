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
    public partial class JadwalGuru : MetroFramework.Forms.MetroForm


    {
      
       

        public JadwalGuru()
        {
            InitializeComponent();
            Fetch();
        }

        private void Fetch()
        {
            listViewJadwal.Clear();
            listViewJadwal.Columns.Add("Kode Mapel", 100);
            listViewJadwal.Columns.Add("Nama Mapel", 100);
            listViewJadwal.Columns.Add("Nama Guru", 100);
            listViewJadwal.Columns.Add("Jam", 100);
            listViewJadwal.Columns.Add("hari", 100);
            listViewJadwal.Columns.Add("ruangan", 100);


            Database db = new Database();
            db.reader = db.callQuery("SELECT * FROM v_jadwalmapel");
            while (db.reader.Read())
            {
                
                string kd_mapel = db.reader.GetString(3);
                string namamapel = db.reader.GetString(4);
                string namaguru = db.reader.GetString(7);
                string jam = db.reader.GetString(8);
                string hari = db.reader.GetString(9);
                string ruangan = db.reader.GetString(10);

                ListViewItem item = new ListViewItem(db.reader.GetString(3));//id_user
                item.SubItems.Add(db.reader.GetString(4));//ID Jadwal
                item.SubItems.Add(db.reader.GetString(7));//Jam
                item.SubItems.Add(db.reader.GetString(8));//hari
                item.SubItems.Add(db.reader.GetString(9));//Ruangan
                item.SubItems.Add(db.reader.GetString(10));//Ruangan

                listViewJadwal.Items.Add(item);

            }
            db.databaseConnection.Close();

        }

        private void metroListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
