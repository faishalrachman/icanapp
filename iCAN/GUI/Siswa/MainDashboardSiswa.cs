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
    public partial class MainDashboardSiswa : MetroFramework.Forms.MetroForm
    {
        M_Siswa siswa;

        public MainDashboardSiswa(int idUser)
        {
            siswa = new M_Siswa(idUser);
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            var form = new frmLihatNilai();
            Hide();
            form.ShowDialog();
            Show();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MainDashboardSiswa_Load(object sender, EventArgs e)
        {
            txnamaSiswa.Text = "Selamat datang, " + siswa.Nama;
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroJadwal_Click(object sender, EventArgs e)
        {
            var form = new frmLihatJadwal(siswa.IdUser);
            Hide();
            form.ShowDialog();
            Show();
        }

        private void metroGuru_Click(object sender, EventArgs e)
        {
            var form = new frmGuruku();
            Hide();
            form.ShowDialog();
            Show();
        }

        private void metroPelajaran_Click(object sender, EventArgs e)
        {
            var form = new MapelSiswa();
            Hide();
            form.ShowDialog();
            Show();
        }
    }
}
