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

namespace iCAN.GUI.Siswa
{
    public partial class frmGuruku : MetroFramework.Forms.MetroForm

    {
        M_Siswa siswa;
        public frmGuruku(int idUser)
        {
            InitializeComponent();
            siswa = new M_Siswa(idUser);
            Fetch();
        }

        private void Fetch()
        {
            Database db = new Database();
<<<<<<< HEAD
            db.reader = db.callQuery("Select * from v_walikelas where id_kelas = '" + siswa.IdKelas + "'");
            if (db.reader.Read())
            {
                string NIP = db.reader.GetString("NIP");
                string nama = db.reader.GetString("nama");
                string alamat = db.reader.GetString("alamat");
                string no_hp = db.reader.GetString("no_hp");

                txNIP.Text = NIP;
                txNama.Text = nama;
                txAlamat.Text = alamat;
                txNomorHP.Text = no_hp;
            }
=======
            db.reader = db.callQuery("Select * from guru ");
            txAlamat.Text = db.reader.GetString("alamat");
>>>>>>> e97259a59ee2e7786031b49f9f1f6f1cced5142a
        }

        private void frmGuruku_Load(object sender, EventArgs e)
        {

        }

        private void htmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void htmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
