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
            listViewJadwal.Columns.Add("ID Jadwal", 100);
            listViewJadwal.Columns.Add("Jam", 100);
            listViewJadwal.Columns.Add("Hari", 100);
            listViewJadwal.Columns.Add("Ruangan", 100);
            
            
            Database db = new Database();
            db.reader = db.callQuery("SELECT * FROM jadwal");
            while (db.reader.Read())
            {
                int id_user = Convert.ToInt32(db.reader.GetString(1));
                string id_jadwal = db.reader.GetString(0);
                string jam = db.reader.GetString(1);
                string hari = db.reader.GetString(2);
                string ruangan = db.reader.GetString(3);
                
                ListViewItem item = new ListViewItem(db.reader.GetString(1));//id_user
                item.SubItems.Add(db.reader.GetString(0));//ID Jadwal
                item.SubItems.Add(db.reader.GetString(1));//Jam
                item.SubItems.Add(db.reader.GetString(2));//hari
                item.SubItems.Add(db.reader.GetString(3));//Ruangan
              
                listViewJadwal.Items.Add(item);

            }
            db.databaseConnection.Close();

        }

        private void metroListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
