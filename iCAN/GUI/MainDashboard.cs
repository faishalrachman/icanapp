using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCAN.GUI
{
    public partial class MainDashboard : MetroFramework.Forms.MetroForm
    {
        static MainDashboard _instance;
        public static MainDashboard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MainDashboard();
                return _instance;

             
                
            }

        }
        public MetroFramework.Controls.MetroPanel MetroContainer
        {
            get { return mPanel; }
            set { mPanel = value; }

        }

        public MetroFramework.Controls.MetroLink MetroBack
        {
            get { return mlBack; }
            set { mPanel = value; }
            
        }
        public MainDashboard()
        {
            InitializeComponent();
        }

        private void DashboardSiswa_Load(object sender, EventArgs e)
        {
            mlBack.Visible = false;
            _instance = this;
            ucDashboard uc = new MainDashboard();
            uc.Dock = DockStyle.Fill;
            mPanel.Controls.Add(uc);


        }

        private void MlBack(object sender, EventArgs e)
        {

            mPanel.Controls["MainDashboard"].BringToFront();
            mlBack.Visible = false;


        }
    }
}
