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
        public frmTambahSiswa(int idUser)
        {
            InitializeComponent();
        }

        private void frmTambahSiswa_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                string query = "INSERT INTO user(username,password,nama, role) VALUES('" + username + "','" + password + "','" + nama + "','admin');";
                Database db = new Database();
                int i = db.CallnonQuery(query);
                if (i > 0)
                {
                    MessageBox.Show("Success");
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
