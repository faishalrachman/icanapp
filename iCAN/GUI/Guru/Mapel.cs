﻿using System;
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
    public partial class Mapel : MetroFramework.Forms.MetroForm
    {
        public Mapel()
        {
            InitializeComponent();
            FetchUser();
        }

        private void FetchUser()
        {
            listviewMapel.Clear();
            listviewMapel.Columns.Add("Kode Mapel", 100);
            listviewMapel.Columns.Add("Nama Mapel", 100);
            listviewMapel.Columns.Add("Nama Guru", 100);
            listviewMapel.Columns.Add("Kelas", 100);
           

            Database db = new Database();
            db.reader = db.callQuery("SELECT * FROM v_mapel");
            while (db.reader.Read())
            {
               
                string id_mapel = db.reader.GetString(0);
                string nama_mapel = db.reader.GetString(1);
                string namaguru = db.reader.GetString(2);
                string namakelas = db.reader.GetString(3);
                
                ListViewItem item = new ListViewItem(db.reader.GetString(1));//id_user
                item.SubItems.Add(db.reader.GetString(2));//ID Mapel
               
                item.SubItems.Add(db.reader.GetString(12));//Nama Guru
                item.SubItems.Add(db.reader.GetString(3));//Nama Kelas
                listviewMapel.Items.Add(item);

            }
            db.databaseConnection.Close();

        }

        private void listviewMapel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
