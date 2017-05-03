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
    public partial class frmTambahKelas : MetroFramework.Forms.MetroForm
    {
        M_Kelas kelas;
        List<M_Guru> l_guru = new List<M_Guru>();
        M_Guru guru;
        public frmTambahKelas()
        {
            InitializeComponent();
            Fetch();
        }
        void Fetch()
        {
            l_guru.Clear();
            Database db = new Database();
            db.reader = db.callQuery("SELECT * FROM v_guru");
            cbGuru.Items.Clear();
            while (db.reader.Read())
            {
                //public M_Guru(int idUser, String idGuru, string nip, string nama, string alamat, string no_hp)
                String id_guru = db.reader.GetString("id_guru");
                int idUser = Convert.ToInt32(db.reader.GetString("id_user"));
                string nip = db.reader.GetString("NIP");
                string nama = db.reader.GetString("nama");
                string alamat = db.reader.GetString("alamat");
                string no_hp = db.reader.GetString("no_hp");
                guru = new M_Guru(idUser, id_guru, nip, nama, alamat, no_hp);
                l_guru.Add(guru);
                cbGuru.Items.Add(guru.Nama);
            }
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            guru = l_guru.ElementAt(cbGuru.SelectedIndex);
            kelas = new M_Kelas(Convert.ToInt32(guru.IdGuru), txNamaKelas.Text);
            MessageBox.Show("Add Jadwal Sukses");
            Fetch();
        }
    }
}
