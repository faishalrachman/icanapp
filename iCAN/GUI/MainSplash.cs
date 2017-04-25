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
    public partial class MainSplash : MetroFramework.Forms.MetroForm
    {
        public MainSplash()
        {
            Thread t = new Thread(new ThreadStart(Loading));
            t.Start();
            
            InitializeComponent();
            for (int i = 0; i <= 1000; i++)
                Thread.Sleep(10);
            t.Abort();
        }
        void Loading()
        {
            SpashScreen frm = new SpashScreen();
            Application.Run(frm);
        }
    }
}
