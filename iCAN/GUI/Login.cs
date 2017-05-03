using iCAN.CLASS;
using iCAN.GUI.Guru;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using iCAN.GUI.Admin;
using iCAN.GUI.Siswa;

namespace iCAN.GUI
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        MainDashboardGuru guru;
        MainDashboardAdmin admin;
        MainDashboardSiswa siswa;
        RegistryKey reg;


        public frmLogin()
        {
            reg = Registry.CurrentUser.CreateSubKey("i-CAN Application");
            InitializeComponent();
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroLink1_MouseClick(object sender, MouseEventArgs e)
        {
            txUsername.Focus();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (guru == null && admin == null)
            {
                Environment.Exit(0);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

            string value = reg.GetValue("username", "-").ToString();
            if (value != "-")
            {
                txUsername.Text = value;
                cbUsername.Checked = true;
            }
        }

        private void login_Clicked(object sender, EventArgs e)
        {

            string username = txUsername.Text;
            string password = txPassword.Text;
            M_User user = new M_User();
            if (user.check_login(username, password))
            {
                switch (user.Role)
                {
                    case "guru":
                        guru = new MainDashboardGuru(user.IdUser);
                        guru.Show();
                        break;
                    case "admin":
                        admin = new MainDashboardAdmin(user.IdUser);
                        admin.Show();
                        break;
                    case "siswa" :
                        siswa = new MainDashboardSiswa();
                        siswa.Show();
                        break;
                    default:
                        break;
                }
                if (cbUsername.Checked == true)
                {
                    reg.SetValue("username", txUsername.Text);
                }
                else
                {
                    reg.SetValue("username", "-");
                }
                Hide();
            }
            else
            {

                MessageBox.Show("username atau password salah", "Error");
            }
        }
    }
}
