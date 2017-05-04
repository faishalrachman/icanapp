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
    public partial class DaftarGuruSiswa : MetroFramework.Forms.MetroForm
    {
        public DaftarGuruSiswa()
        {
            InitializeComponent();
            FetchUser();
        }

        private void FetchUser()
        {
            metroListGuru.Clear();

            metroListGuru.Columns.Add("NIP", 100);
            metroListGuru.Columns.Add("Nama", 100);
            metroListGuru.Columns.Add("Alamat", 100);
            metroListGuru.Columns.Add("No HP", 100);
            Database db = new Database();
            db.reader = db.callQuery("SELECT * FROM v_guru");
            while (db.reader.Read())
            {
                int id_user = Convert.ToInt32(db.reader.GetString(1));
                string id_guru = db.reader.GetString(0);
                string nip = db.reader.GetString(2);
                string nama = db.reader.GetString(3);
                string alamat = db.reader.GetString(4);
                string no_hp = db.reader.GetString(5);
                ListViewItem item = new ListViewItem(db.reader.GetString(2));//id_user
                item.SubItems.Add(db.reader.GetString(3));//ID Guru
                item.SubItems.Add(db.reader.GetString(4));//NIP
                item.SubItems.Add(db.reader.GetString(5));//nama

                metroListGuru.Items.Add(item);
            }
            db.databaseConnection.Close();

        }
    }
}
