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
    public partial class frmTambahGuru : MetroFramework.Forms.MetroForm
    {
        M_Guru guru;
        public frmTambahGuru()
        {
            InitializeComponent();
            guru = new M_Guru();
        }

        private void frmTambahGuru_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool check_value()
        {
            if (txAlamat.Text == "" || txNama.Text == "" || txNIP.Text == "" || txUsername.Text == "" || txNoHP.Text == "")
                return false;

            return true;
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (check_value())
            {
                guru.Alamat = txAlamat.Text;
                guru.Nama = txNama.Text;
                guru.myNIP = txNIP.Text;
                guru.Username = txUsername.Text;
                guru.Password = txPassword.Text;
                guru.No_hp = txNoHP.Text;
                if (guru.addGurutoDB())
                {
                    MessageBox.Show("Guru " + guru.Nama + " berhasil di Inputkan");
                    Close();
                }
                else
                {
                    MessageBox.Show("Error");
                }
                
            }
            else
            {
                MessageBox.Show("Lengkapi data terlebih dahulu");
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
