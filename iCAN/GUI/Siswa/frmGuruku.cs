using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCAN.GUI.Siswa
{
    public partial class frmGuruku : MetroFramework.Forms.MetroForm
    {
        public frmGuruku()
        {
            InitializeComponent();
            Fetch();
        }

        private void Fetch()
        {
            Database db = new Database();
            db.reader = db.callQuery("Select * from guru ");
            txAlamat.Text = db.reader.GetString("alamat");
        }

        private void frmGuruku_Load(object sender, EventArgs e)
        {

        }

        private void htmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void htmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
