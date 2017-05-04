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
    public partial class waliKelas : MetroFramework.Forms.MetroForm
    {
        public waliKelas()
        {
            InitializeComponent();
            FetchUser();
        }

        private void FetchUser()
        {
            metroWali.Clear();

            metroWali.Columns.Add("Nama Guru", 100);
            metroWali.Columns.Add("Kelas", 100);

            Database db = new Database();
            db.reader = db.callQuery("SELECT * FROM v_kelas");
            while (db.reader.Read())
            {
                string nama_wali = db.reader.GetString("nama");
                string nama_kelas = db.reader.GetString("nama_kelas");
                ListViewItem item = new ListViewItem(nama_wali);//id_user
                item.SubItems.Add(nama_kelas);//ID Guru
                metroWali.Items.Add(item);
            }
            db.databaseConnection.Close();
        }
    }
}
