﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iCAN.CLASS;

namespace iCAN.GUI.Admin
{
    public partial class frmKelolaMapel : MetroFramework.Forms.MetroForm
    {
        M_Mapel mapel;
        List<M_Mapel> l_mapel;
        public frmKelolaMapel()
        {
            InitializeComponent();
            FetchMapel();
        }
        void FetchMapel()
        {

            //txIsi.Text = "";
            //txInputJudul.Text = "";
            //l_berita = new List<M_Berita>();
            //Database db = new Database();
            //cbOpsiJudul.Items.Clear();
            //db.reader = db.callQuery("SELECT * FROM v_mapel");
            //while (db.reader.Read())
            //{
            //    //1                Kemahalan Harga KTM                KTM jadi mahal euy 1
            //    int idNews = Convert.ToInt32(db.reader.GetString(0));
            //    string judul = db.reader.GetString(1);
            //    string isi = db.reader.GetString(2);
            //    berita = new M_Berita(idNews, judul, isi);
            //    l_berita.Add(berita);
            //    cbOpsiJudul.Items.Add(db.reader.GetString(1));
            //    //id_jadwal id_kelas    id_guru id_mapel    nama_mapel id_user     NIP nama    jam hari    ruangan
            tb_mapel.Clear();
            tb_mapel.Columns.Add("Kode Mata pelajaran",150);
            tb_mapel.Columns.Add("Nama Mata Pelajaran",150);
            tb_mapel.Columns.Add("Hari",50);
            tb_mapel.Columns.Add("Jam",50);
            tb_mapel.Columns.Add("Nama Guru",50);
            tb_mapel.Columns.Add("Ruangan",50);
            l_mapel = new List<M_Mapel>();

            Database db = new Database();
            db.reader = db.callQuery("SELECT * FROM v_jadwalmapel");
            while (db.reader.Read())
            {
                String kdMapel = db.reader.GetString("kd_mapel");
                String nmMapel = db.reader.GetString("nama_mapel"); 
                String jam = db.reader.GetString("jam"); 
                String hari = db.reader.GetString("hari"); 
                String nama_guru = db.reader.GetString("nama"); 
                String ruangan = db.reader.GetString("ruangan");

                l_mapel.Add(new M_Mapel(kdMapel, nmMapel, jam, hari, nama_guru, ruangan));
                ListViewItem item = new ListViewItem(kdMapel);//id_user
                item.SubItems.Add(nmMapel);//nis
                item.SubItems.Add(hari);//nis
                item.SubItems.Add(jam);//nis
                item.SubItems.Add(nama_guru);//nis
                item.SubItems.Add(ruangan);//nis
                tb_mapel.Items.Add(item);
            }
        }

        private void tb_mapel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tb_mapel.SelectedItems.Count > 0)
                mapel = l_mapel.ElementAt(tb_mapel.SelectedIndices[0]);
            txGuru.Text = mapel.Nama_guru;
            txKdMapel.Text = mapel.KdMapel;
            txNamaMapel.Text = mapel.NmMapel;
            txRuangan.Text = mapel.Ruangan;
            }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var f = new frmTambahMapel();
            Hide();
            f.ShowDialog();
            FetchMapel();
            Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah anda yakin akan menghapus mata pelajaran ini?", "PERINGATAN", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Database db = new Database();
                bool i = db.CallnonQuery("DELETE FROM mapel where kd_mapel = '" + mapel.KdMapel + "'");
                if (i)
                {
                    MessageBox.Show("Berhasil terhapus");
                    FetchMapel();
                }
            }
        }

        private void frmKelolaMapel_Load(object sender, EventArgs e)
        {

        }
            
    }

}
