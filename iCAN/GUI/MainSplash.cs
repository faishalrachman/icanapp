using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCAN.GUI
{
    public partial class frmSplash : MetroFramework.Forms.MetroForm
    {
        public frmSplash()
        {
            Thread t = new Thread(new ThreadStart(Loading));
            t.Start();
            
            InitializeComponent();
            for (int i = 0; i <= 300; i++)
                Thread.Sleep(10);
            var Form = new frmLogin();
            Form.Show();
            t.Abort();
            this.Hide();

        }
        void Loading()
        {
            SpashScreen frm = new SpashScreen();
            Application.Run(frm);
        }
    }
}
