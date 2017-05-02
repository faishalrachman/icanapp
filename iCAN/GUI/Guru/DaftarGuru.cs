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
    public partial class DaftarGuru : MetroFramework.Forms.MetroForm
    {

        public DaftarGuru()
        {
            InitializeComponent();
            FetchUser();
        }
        void FetchUser()
        {
            listViewGuru.Clear();
            listViewGuru.Columns.Add("ID User", 100);
            listViewGuru.Columns.Add("ID Guru", 100);
            listViewGuru.Columns.Add("NIP", 100);
            listViewGuru.Columns.Add("Nama", 100);
            listViewGuru.Columns.Add("Alamat", 100);
            listViewGuru.Columns.Add("No HP", 50);
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
                ListViewItem item = new ListViewItem(db.reader.GetString(1));//id_user
                item.SubItems.Add(db.reader.GetString(0));//ID Guru
                item.SubItems.Add(db.reader.GetString(2));//NIP
                item.SubItems.Add(db.reader.GetString(3));//nama
                item.SubItems.Add(db.reader.GetString(4));//Alamat
                item.SubItems.Add(db.reader.GetString(5));//No_hp
                listViewGuru.Items.Add(item);
            }
            db.databaseConnection.Close();
        }

        private void listViewGuru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
