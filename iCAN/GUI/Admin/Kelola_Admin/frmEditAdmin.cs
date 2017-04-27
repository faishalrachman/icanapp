using System;
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
    public partial class frmEditAdmin : MetroFramework.Forms.MetroForm
    {
        int idUser;
        public frmEditAdmin(int idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
            Database db = new Database();
            db.reader = db.callQuery("SELECT username, nama FROM user WHERE id=" + idUser + ";");
            if (db.reader.Read())
            {
                txUsername.Text = db.reader.GetString(0);
                txNama.Text = db.reader.GetString(1);

            }

        }

        private void frmEditAdmin_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            string Query = "UPDATE user SET nama = '" + txNama.Text + "'";
            if (txPassword.Text.Length > 0)
            {
                Query += ", password = '" + txPassword.Text + "'";
            }
                Query += " WHERE id = " + idUser + "; ";
            bool i =  db.CallnonQuery(Query);
            if (i){
                Close();
            }
        }
    }
}
