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
    public partial class MapelSiswa : MetroFramework.Forms.MetroForm
    {
        public MapelSiswa()
        {
            InitializeComponent();
            Fetch();
        }

        private void Fetch()
        {
            metroListMapel.Clear();
            metroListMapel.Columns.Add("Kode Mapel", 100);
            metroListMapel.Columns.Add("Nama Mapel", 100);
            metroListMapel.Columns.Add("Nama Guru", 100);
            metroListMapel.Columns.Add("Kelas", 100);


            Database db = new Database();
            db.reader = db.callQuery("SELECT * FROM v_mapel");
            while (db.reader.Read())
            {

                string id_mapel = db.reader.GetString(0);
                string nama_mapel = db.reader.GetString(1);
                string namaguru = db.reader.GetString(2);
                string namakelas = db.reader.GetString(3);

                ListViewItem item = new ListViewItem(db.reader.GetString(1));//id_user
                item.SubItems.Add(db.reader.GetString(2));//ID Mapel

                item.SubItems.Add(db.reader.GetString(12));//Nama Guru
                item.SubItems.Add(db.reader.GetString(3));//Nama Kelas
                metroListMapel.Items.Add(item);

            }
            db.databaseConnection.Close();
        }

        private void metroListMapel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
