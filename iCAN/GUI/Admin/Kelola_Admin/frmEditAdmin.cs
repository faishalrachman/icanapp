using iCAN.CLASS;
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
        M_User user;
        public frmEditAdmin(int idUser)
        {
            InitializeComponent();
            user = new M_User(idUser);
            
                txUsername.Text = user.Username;
                txNama.Text = user.Nama;
            
        }

        private void frmEditAdmin_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //Database db = new Database();
            //string Query = "UPDATE user SET nama = '" + txNama.Text + "'";
            //if (txPassword.Text.Length > 0)
            //{
            //    Query += ", password = '" + txPassword.Text + "'";
            //}
            //    Query += " WHERE id = " + idUser + "; ";
            //bool i =  db.CallnonQuery(Query);
            //if (i){
            //    Close();
            //}
            user.Nama = txNama.Text;
            if (txPassword.Text != "")
                user.Password = txPassword.Text;
            if (user.saveUsertoDB())
            {
                Close();
            }
        }
    }
}
