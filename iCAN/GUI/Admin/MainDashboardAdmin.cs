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
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {

            var form = new frmKelolaUser();
            Hide();
            form.ShowDialog();
            Show();
        }

        private void MainDashboardAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {

        }
    }
}
