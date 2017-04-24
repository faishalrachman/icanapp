using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iCAN.CLASS;

namespace iCAN.GUI.Guru
{
    public partial class MainDashboardGuru : MetroFramework.Forms.MetroForm
    {
        int id_user;
        M_Guru guru;

        public MainDashboardGuru()
        {
            InitializeComponent();
        }

        private void MainDashboardGuru_Load(object sender, EventArgs e)
        {
            
        }

        private void MainDashboardGuru_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
