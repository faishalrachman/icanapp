using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCAN.CLASS
{
    class M_Nilai
    {
        //INSERT INTO `nilai` (`id_nilai`, `kd_mapel`, `NIS`, `nama_nilai`, `skor`) VALUES (NULL, 'FIS-2', '1310003', 'UJIAN 1', '100');
        private String id_nilai;
        private String nama_mapel;
        private String nama_siswa;
        private double skor;

        public string Id_nilai { get { return id_nilai; } set { this.id_nilai = value; } }
        public string Nama_mapel
        {
            get { return nama_mapel; }
            set { this.nama_mapel = value; }
        }
        public double Skor
        {
            get { return skor; }
            set { this.skor = value; }
        }
        public string Nama_siswa
        {
            get { return nama_siswa; }
            set { this.nama_siswa = value; }
        }

        public M_Nilai(string id_nilai, string nama_mapel, string nama_siswa, float skor)
        {
            this.id_nilai = id_nilai;
            this.nama_mapel = nama_mapel;
            this.nama_siswa = nama_siswa;
            this.skor = skor;
        }
        public M_Nilai(string id_nilai)
        {
            Database db = new Database();
            db.reader = db.callQuery("SELECT * FROM v_nilai where id_nilai = "+id_nilai);
            if (db.reader.Read())
            {
                this.id_nilai = id_nilai;
                nama_mapel = db.reader.GetString("nama_mapel");
                nama_siswa = db.reader.GetString("nama");
                skor = Convert.ToDouble(db.reader.GetString("skor"));
            }
        }
        public M_Nilai()
        {

        }

        public void addtoDB(String kd_mapel, String nama_nilai, String NIS, double skor)
        {
            Database db = new Database();
            string query = "INSERT INTO nilai (kd_mapel,nama_nilai,NIS,skor) VALUES ('" + kd_mapel + "','" + nama_nilai + "'," + NIS + "," + skor + ")";
            db.CallnonQuery(query);
        }
        public bool savetoDB()
        {
            Database db = new Database();
            string query = "UPDATE nilai SET skor = '" + skor + "' where id_nilai = " + id_nilai;
            bool i = db.CallnonQuery(query);
            return i;
        }
        public bool deletefromDB()
        {
            Database db = new Database();
            string query = "DELETE FROM nilai where id_nilai = " + id_nilai;
            bool i = db.CallnonQuery(query);
            return i;
        }
    }
}
