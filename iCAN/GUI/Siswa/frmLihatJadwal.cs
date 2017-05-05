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
        int idUser;
        public frmLihatJadwal(int idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
            Fetch();

        }

        private void Fetch()
        {
            lvjawalsiswa.Clear();
            lvjawalsiswa.Columns.Add("Nama Mata Pelajaran", 200);
            lvjawalsiswa.Columns.Add("Jam", 100);
            lvjawalsiswa.Columns.Add("Hari", 100);
            lvjawalsiswa.Columns.Add("Ruangan", 100);


            Database db = new Database();
            db.reader = db.callQuery("SELECT * FROM mapel JOIN jadwal using (id_jadwal) JOIN siswa using (id_kelas) where id_user = "+idUser);
            while (db.reader.Read())
            {

                string nama_mapel = db.reader.GetString("nama_mapel");
                string jam = db.reader.GetString("jam");
                string hari = db.reader.GetString("hari");
                string ruangan = db.reader.GetString("ruangan");

                ListViewItem item = new ListViewItem(nama_mapel);//id_user
                item.SubItems.Add(jam);//ID Jadwal
                item.SubItems.Add(hari);//Jam
                item.SubItems.Add(ruangan);//hari
                lvjawalsiswa.Items.Add(item);

            }
        }

        private void frmLihatJadwal_Load(object sender, EventArgs e)
        {

        }
    }
}
