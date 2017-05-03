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
using Transitions;

namespace iCAN.GUI.Admin
{
    public partial class MainDashboardAdmin : MetroFramework.Forms.MetroForm
    {
        M_Admin admin;
        public MainDashboardAdmin(int idUser)
        {
            admin = new M_Admin(idUser);
            InitializeComponent();
        }
        

        private void MainDashboardAdmin_Load(object sender, EventArgs e)
        {


            for (double i = 0; i < 100; ++i)
            {
                this.Opacity = i / 100;
                Application.DoEvents();
                System.Threading.Thread.Sleep(0);
            }
            lb_welcome.Text = "Selamat Datang, " + admin.Nama;
            }

        private void MainDashboardAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            var form = new frmKelolaSiswa();
            Hide();
            form.ShowDialog();
            Show();
            Focus();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {

            var form = new frmKelolaUser();
            Hide();
            form.ShowDialog();
            Show();
            Focus();
        }
        
        private void MainDashboardAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            var form = new frmKelolaBerita();
            Hide();
            form.ShowDialog();
            Show();
            Focus();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            var form = new frmKelolaGuru();
            Hide();
            form.ShowDialog();
            Show();
            Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            var form = new frmKelolaMapel();
            Hide();
            form.ShowDialog();
            Show();
            Focus();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            var form = new frmKelolaKelas();
            Hide();
            form.ShowDialog();
            Show();
            Focus();

        }

        private void metroTile8_Click(object sender, EventArgs e)
        {

            var form = new frmKelolaJadwal();
            Hide();
            form.ShowDialog();
            Show();
            Focus();
        }
    }
}
