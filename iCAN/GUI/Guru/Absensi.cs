using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCAN.GUI.Guru
{
    public partial class Absensi : MetroFramework.Forms.MetroForm
    {
        public Absensi()
        {
          
            InitializeComponent();
            metroListView1.BeginUpdate();
            metroListView1.Items.Clear();
            metroListView1.View = View.Details;
            // Add a column with width 20 and left alignment.
            //Set Columns
            metroListView1.Columns.Add("Nama");
            metroListView1.Columns.Add("NIS");
            metroListView1.Columns.Add("Kelas");
            metroListView1.Columns.Add("Col4");
            metroListView1.Columns.Add("Col5");
            metroListView1.CheckBoxes = true;

            //Fill Rows
            for (int i = 0; i < 1000; i++)
            {
                ListViewItem lvi;
                lvi = new ListViewItem(new string[] { "Aaaaa Sample" + i, "Bbbbb" + i, "Cccccc" + i, "Ddddd" + +i, "Eeeee" + +i });
                metroListView1.Items.Add(lvi);
                metroListView1.Items[0].Checked = true;
            }

            metroListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            metroListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            metroListView1.EndUpdate();
            metroListView1.AllowSorting = true;

        }

        private void metroScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void metroListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
