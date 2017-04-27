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
        string konek = "Connecting To Database ...";
        string start = "Starting application";
        string error = "Failed to Connect to Database";
        string tryagain = "Reconnecting To Database ...";
        string success = "Connect to database success ...";
        Database db = new Database();
        public SpashScreen()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void setNotif(string text)
        {
            notification.Text = text;
        }
        private void SpashScreen_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
        }
    }
}
