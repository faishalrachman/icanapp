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

namespace iCAN.GUI.Guru
{
    public partial class DaftarSiswa : MetroFramework.Forms.MetroForm
    {
        M_Kelas kelas;
        public DaftarSiswa()
        {
            InitializeComponent();
            FetchUser();
        }

        private void FetchUser()
        {
            listViewSiswa.Clear();
            listViewSiswa.Columns.Add("NIS", 100);
            listViewSiswa.Columns.Add("Nama Siswa", 100);
            listViewSiswa.Columns.Add("Jenis Kelamin", 100);
            listViewSiswa.Columns.Add("Kelas", 100);
            listViewSiswa.Columns.Add("Tempat Lahir", 100);
            listViewSiswa.Columns.Add("Tanggal Lahir", 100);
            listViewSiswa.Columns.Add("Agama", 50);
            listViewSiswa.Columns.Add("Alamat", 50);
            Database db = new Database();
            db.reader = db.callQuery("SELECT * FROM v_siswa");
            while (db.reader.Read())
            {
                int id_user = Convert.ToInt32(db.reader.GetString(0));
                string nis = db.reader.GetString(0);
                string nama = db.reader.GetString(1);
                string jk = db.reader.GetString(2);
                string kelas = db.reader.GetString(3);
                string temlahir = db.reader.GetString(4);
                string tgllahir = db.reader.GetString(5);
                string agama = db.reader.GetString(6);
                string alamat = db.reader.GetString(6);
                ListViewItem item = new ListViewItem(db.reader.GetString(0));//id_user
               
                item.SubItems.Add(db.reader.GetString(2));
                item.SubItems.Add(db.reader.GetString(3));
                item.SubItems.Add(db.reader.GetString(4));
                item.SubItems.Add(db.reader.GetString(5));
                item.SubItems.Add(db.reader.GetString(6));
                item.SubItems.Add(db.reader.GetString(7));
                item.SubItems.Add(db.reader.GetString(8));
                listViewSiswa.Items.Add(item);

            }
                db.databaseConnection.Close();

            
        }

        private void listViewSiswa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
