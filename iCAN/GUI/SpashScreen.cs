using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace iCAN.GUI
{
    public partial class SpashScreen : MetroFramework.Forms.MetroForm
    {
        public SpashScreen()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer_tik(object sender, EventArgs e)
        {
            int i = 0;
            if (i < 5)
            {
                i++;
            }
            else
            {
                timer1.Enabled = false;
                var form = new frmLogin();
                form.Show();
                Close();
            }
        }
    }
}
