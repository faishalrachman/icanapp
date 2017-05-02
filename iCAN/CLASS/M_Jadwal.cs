using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCAN.CLASS
{
    class M_Jadwal 
    {
        private String idJadwal;
        public String tanggal;
        public String jam;

        public M_Jadwal(String tanggal, String ruangan)
        {
            this.jam = jam;
            this.tanggal = tanggal;
        }

        public String getId()
        {
            return idJadwal;
        }

        public bool addtoDB()
        {
            Database db = new Database();
            string query = "INSERT INTO jadwal(tanggal,jam) VALUES('" + tanggal + "','" + jam + "')";
            bool i = db.CallnonQuery(query);
            //if (i)
            //{
            //    db.reader = db.callQuery("SELECT id_jadwal from jadwal where tanggal = '" + tanggal + "' AND jam = '" + jam + "'");
            //    if (db.reader.Read())
            //        idJadwal = db.reader.GetString(0);
            //}
            return i;
        }

        //public bool savetoDB()
        //{
        //    Database db = new Database();
        //    string query = "UPDATE jadwal SET judul = '" + judul + "', isi = '" + isi + "' where id_berita = " + idNews;
        //    bool i = db.CallnonQuery(query);
        //    return i;
        //}
        //public bool deletefromDB()
        //{
        //    Database db = new Database();
        //    string query = "DELETE FROM berita where id_berita = " + idNews;
        //    bool i = db.CallnonQuery(query);
        //    return i;
        //}
    }
}
