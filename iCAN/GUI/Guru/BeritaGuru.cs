using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCAN.GUI.Guru
{
    public partial class BeritaGuru : MetroFramework.Forms.MetroForm
    {
        string berita;
        private object beritaGuru;
        public BeritaGuru()
        {
            InitializeComponent();
            Fetch();
        }

        private void Fetch()
        {
            Database db = new Database();
            db.reader = db.callQuery("SELECT * FROM berita");
            while (db.reader.Read())
            {
                berita += db.reader.GetString("judul");
                berita += "@==============================@";
                berita += "@";
                berita += db.reader.GetString("isi");
                berita += "@";
            }
            if (berita != null && berita.Contains("@"))
            {
                berita = berita.Replace("@", System.Environment.NewLine);
            }
            txBerita.Text = berita;
        }

        private void htmlPanel1_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void BeritaGuru_Load(object sender, EventArgs e)
        {
        }
    }
}
