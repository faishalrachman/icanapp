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

namespace iCAN.GUI.Admin
{
    public partial class frmEditSiswa : MetroFramework.Forms.MetroForm
    {
        int idUser;
        public frmEditSiswa(int idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
        }

        private void frmEditSiswa_Load(object sender, EventArgs e)
        {
            Database db = new Database();
            string idkelas = "";
            db.reader = db.callQuery("SELECT username from user where id=" + idUser);
            if (db.reader.Read())
            {
                txUsername.Text = db.reader.GetString(0);
            }
            db.Closedb();
            db.reader = db.callQuery("SELECT * from v_siswa where id_user = " + idUser);
            if (db.reader.Read())
            {
                txNIS.Text = db.reader.GetString(0);
                txNama.Text = db.reader.GetString(2);
                if (db.reader.GetString(3) == "1")
                    cbJK.SelectedIndex = 0;
                else
                    cbJK.SelectedIndex = 1;

                cbKelas.Text = db.reader.GetString(4);
                txTempatL.Text = db.reader.GetString(5);
                txTanggalL.Value = Convert.ToDateTime(db.reader.GetString(6));
                switch (db.reader.GetString(6))
                {
                    case "Islam":
                        cbAgama.SelectedIndex = 0;
                        break;
                    case "Katholik":
                        cbAgama.SelectedIndex = 1;
                        break;
                    case "Protestan":
                        cbAgama.SelectedIndex = 2;
                        break;
                    case "Hindu":
                        cbAgama.SelectedIndex = 3;
                        break;
                    case "Budha":
                        cbAgama.SelectedIndex = 4;
                        break;
                    case "Konghuchu":
                        cbAgama.SelectedIndex = 5;
                        break;
                    default:
                        cbAgama.SelectedIndex = 0;
                        break;
                }
                cbAgama.SelectedText = db.reader.GetString(7);
                txAlamat.Text = db.reader.GetString(8);
            }
            db.Closedb();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool check_value()
        {
            if (txAlamat.Text == "" || txNama.Text == "" || txNIS.Text == "" || txPassword.Text == "" || txTanggalL.Text == "" || txTempatL.Text == "" || cbAgama.Text == "" || cbJK.Text == "" || cbKelas.Text == "")
                return false;

            return true;
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txUsername.Text == "" && txPassword.Text == "" && txNama.Text == "")
            {
                MessageBox.Show("Isi data terlebih dahulu");
            }
            else
            {
                string username = txUsername.Text;
                string password = txPassword.Text;
                int idKelas = -1;
                Database db = new Database();
                string query = "SELECT id_kelas from kelas where nama_kelas = '" + cbKelas.Text + "';";
                MessageBox.Show(query);
                db.reader = db.callQuery(query);

                if (db.reader.Read())
                {
                    idKelas = Convert.ToInt32(db.reader.GetString(0));
                }
                db.databaseConnection.Close();
                int jk = 0;
                if (cbJK.Text == "Laki-laki")
                {
                    jk = 1;
                }
                if (password != "")
                {
                    db.CallnonQuery("UPDATE user SET password = '" + password + "' where id = " + idUser);
                }

                string nama = txNama.Text;
                string tempat = txTempatL.Text;
                string tanggal = txTanggalL.Value.ToString();
                string agama = cbAgama.Text;
                string alamat = txAlamat.Text;
                query = "UPDATE siswa SET id_kelas = '" + idKelas + "', tempat_lahir = '" + tempat + "', tanggal_lahir = '" + tanggal + "', agama = '" + agama + "', alamat = '"+alamat+"' WHERE NIS = " + txNIS.Text + " ";
                
                bool i = db.CallnonQuery(query);
                MessageBox.Show(query);
                if (i)
                {
                    Close();
                }


            }
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }
    }
}
