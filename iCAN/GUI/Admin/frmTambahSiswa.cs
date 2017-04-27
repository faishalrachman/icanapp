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
    public partial class frmTambahSiswa : MetroFramework.Forms.MetroForm
    {
        int idUser;
        public frmTambahSiswa()
        {
            InitializeComponent();
        }

        private void frmTambahSiswa_Load(object sender, EventArgs e)
        {
            Database db = new Database();
            db.reader = db.callQuery("SELECT nama_kelas from kelas");
            while (db.reader.Read())
            {
                cbKelas.Items.Add(db.reader.GetString(0));
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
                string nama = txNama.Text;
                string tempat = txTempatL.Text;
                string tanggal = txTanggalL.Value.ToString();
                string agama = cbAgama.Text;
                string alamat = txAlamat.Text;
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
                query = "INSERT INTO user(username,password,nama, role) VALUES('" + username + "','" + password + "','" + nama + "','siswa');";
                MessageBox.Show(query);
                bool i = db.CallnonQuery(query);
                if (i)
                {
                    query = "SELECT * FROM user where username = '" + username + "';";
                MessageBox.Show(query);
                    db.reader = db.callQuery(query);
                    if (db.reader.Read())
                    {
                         idUser =  Convert.ToInt32(db.reader.GetString(0));
                        MessageBox.Show("Insert User success, id = " + idUser);
                        db.databaseConnection.Close();
                        query = "INSERT INTO siswa (`id_user`, `jenis_kelamin`, `id_kelas`, `tempat_lahir`, `tanggal_lahir`, `agama`, `alamat`) VALUES ('" + idUser + "', '" + jk + "', '" + idKelas + "', '" + tempat + "', '" + tanggal + "', '" + agama + "', '" + alamat + "');";
                        i = db.CallnonQuery(query);
                        MessageBox.Show(query);
                        if (i)
                        {
                            MessageBox.Show("Insert Siswa success, id = " + idUser);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Udah ada euy");
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
