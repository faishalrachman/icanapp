using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace iCAN.CLASS
{
    class M_Kelas
    {
        private String idKelas;

        public String IdKelas
        {
            get { return idKelas; }
            set { idKelas = value; }
        }
        private String nama_kelas;

        public String Nama_kelas
        {
            get { return nama_kelas; }
            set { nama_kelas = value; }
        }
        private String nama_wali;

        public String Nama_wali
        {
            get { return nama_wali; }
            set { nama_wali = value; }
        }

        public M_Kelas(string idKelas, string nama_kelas, String nama_wali)
        {
            this.idKelas = idKelas;
            this.nama_kelas = nama_kelas;
            this.nama_wali = nama_wali;
        }
        public M_Kelas(string idKelas)
        {
            Database db = new Database();
            db.reader = db.callQuery("SELECT * FROM v_kelas where id_kelas =" + idKelas);
            if (db.reader.Read())
            {
                nama_kelas = db.reader.GetString("nama_kelas");
                nama_wali = db.reader.GetString("nama_guru");
            }
        }
        public M_Kelas(string nama_kelas, string nama_wali)
        {
            this.nama_kelas = nama_kelas;
            this.nama_wali = nama_wali;
        }
        public M_Kelas(int id_guru, string nama_kelas)
        {
            Database db = new Database();
            string query = "INSERT INTO kelas(id_guru,nama_kelas) VALUES(" + id_guru + ",'" + nama_kelas + "')";
            bool i = db.CallnonQuery(query);
        }

        public bool deletefromDB()
        {
            Database db = new Database();
            string query = "DELETE FROM kelas where id_kelas = " + idKelas;
            bool i = db.CallnonQuery(query);
            return i;
        }
    }
}
