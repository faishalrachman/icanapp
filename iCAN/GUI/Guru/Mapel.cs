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
    public partial class Mapel : MetroFramework.Forms.MetroForm
    {
        public Mapel()
        {
            InitializeComponent();
            FetchUser();
        }

        private void FetchUser()
        {
            listviewMapel.Clear();
            listviewMapel.Columns.Add("Kode Mapel", 100);
            listviewMapel.Columns.Add("Nama Mapel", 100);
            listviewMapel.Columns.Add("Nama Guru", 100);

            Database db = new Database();
            db.reader = db.callQuery("SELECT * FROM v_mapel");
            while (db.reader.Read())
            {
               
                string kd_mapel = db.reader.GetString("kd_mapel");
                string nama_mapel = db.reader.GetString("nama_mapel");
                string namaguru = db.reader.GetString("nama");
                
                
                ListViewItem item = new ListViewItem(kd_mapel);//id_user
                item.SubItems.Add(db.reader.GetString(nama_mapel));
                item.SubItems.Add(db.reader.GetString(namaguru));//Nama Guru
                
                listviewMapel.Items.Add(item);

            }
            db.databaseConnection.Close();

        }

        private void listviewMapel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
