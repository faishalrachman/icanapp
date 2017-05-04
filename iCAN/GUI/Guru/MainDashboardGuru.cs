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

namespace iCAN.GUI.Guru
{
    public partial class MainDashboardGuru : MetroFramework.Forms.MetroForm
    {
     
        M_Guru guru;
        int idGuru;
        public MainDashboardGuru(int idGuru)
        {
            guru = new M_Guru(idGuru);
            this.idGuru = idGuru;
            InitializeComponent();
        }

        private void MainDashboardGuru_Load(object sender, EventArgs e)
        {

            for (double i = 0; i < 100; ++i)
            {
                this.Opacity = i / 100;
                Application.DoEvents();
                System.Threading.Thread.Sleep(0);
            }
            lb_welcome.Text = "Selamat Datang, " + guru.Nama;
        }

    private void MainDashboardGuru_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void mAbsensi_Click(object sender, EventArgs e)
        {
            Hide();
            new Absensi(idGuru).ShowDialog();
            Show();
        }

        private void mNilai_Click(object sender, EventArgs e)
        {
            var form = new NilaiGuru(idGuru);
            Hide();
            form.ShowDialog();
            Show();
        }

        private void mDaftarGuru_Click(object sender, EventArgs e)
        {
            var form = new DaftarGuru();
            Hide();
            form.ShowDialog();
            Show();
        }

        private void mBeritaGuru_Click(object sender, EventArgs e)
        {
            var form = new BeritaGuru();
            Hide();
            form.ShowDialog();
            Show(); 
        }

        private void mProfileGuru_Click(object sender, EventArgs e)
        {
            var form = new ProfilGuru();
            Hide();
            form.ShowDialog();
            Show();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mtJadwal(object sender, EventArgs e)
        {


        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            var form = new DaftarSiswa();
            Hide();
            form.ShowDialog();
            Show();

        }

        private void mtJadwalGuru_Click(object sender, EventArgs e)
        {
            var form = new JadwalGuru();
            Hide();
            form.ShowDialog();
            Show();

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void mMapel_Click(object sender, EventArgs e)
        {
            var form = new Mapel();
            Hide();
            form.ShowDialog();
            Show();
        }
    }
}
