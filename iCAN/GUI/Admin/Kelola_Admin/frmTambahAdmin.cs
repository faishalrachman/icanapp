﻿using System;
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
    public partial class frmTambahAdmin : MetroFramework.Forms.MetroForm
    {
        public frmTambahAdmin(int idUser)
        {
            InitializeComponent();
        }

        private void frmTambahAdmin_Load(object sender, EventArgs e)
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
                bool i = db.CallnonQuery(query);
                if (i)
                {
                    MessageBox.Show("Success");
                }
                
            }
        }
    }
}
