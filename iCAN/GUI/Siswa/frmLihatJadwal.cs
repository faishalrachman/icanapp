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
    public partial class frmLihatJadwal : MetroFramework.Forms.MetroForm
    {
        public frmLihatJadwal()
        {
            InitializeComponent();
            Fetch();

        }

        private void Fetch()
        {
            lvjawalsiswa.Clear();
            lvjawalsiswa.Columns.Add("ID Jadwal", 100);
            lvjawalsiswa.Columns.Add("Jam", 100);
            lvjawalsiswa.Columns.Add("Hari", 100);
            lvjawalsiswa.Columns.Add("Ruangan", 100);


            Database db = new Database();
            db.reader = db.callQuery("SELECT * FROM jadwal");
            while (db.reader.Read())
            {

                string id_jadwal = db.reader.GetString(0);
                string jam = db.reader.GetString(1);
                string hari = db.reader.GetString(2);
                string ruangan = db.reader.GetString(3);

                ListViewItem item = new ListViewItem(db.reader.GetString(1));//id_user
                item.SubItems.Add(db.reader.GetString(0));//ID Jadwal
                item.SubItems.Add(db.reader.GetString(1));//Jam
                item.SubItems.Add(db.reader.GetString(2));//hari
                item.SubItems.Add(db.reader.GetString(3));//Ruangan

                lvjawalsiswa.Items.Add(item);

            }
            db.databaseConnection.Close();




        }

        private void frmLihatJadwal_Load(object sender, EventArgs e)
        {

        }

        private void lvjawalsiswa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
