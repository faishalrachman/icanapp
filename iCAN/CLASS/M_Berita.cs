using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCAN.CLASS
{
    class M_Berita
    {
        public int idNews = -1;
        public String judul;
        public String isi;
        private Database db;

        public M_Berita(int idNews, String judul, String isi)
        {
            this.idNews = idNews;
            this.judul = judul;
            this.isi = isi;
        }
        public M_Berita(String judul, String isi)
        {
            this.judul = judul;
            this.isi = isi;
            addBeritatoDB();
        }
        public M_Berita(int idNews)
        {
            db = new Database();
            db.reader = db.callQuery("SELECT * from berita where id_berita = "+idNews);
            if (db.reader.Read())
            {
                judul = db.reader.GetString(1);
                isi = db.reader.GetString(2);
            }
        }

        public void setJudul(String judul)
        {
            this.judul = judul;
        }

        public String getJudul()
        {
            return judul;
        }

        public void setIsi(String Isi)
        {
            isi = isi;
        }

        public String getIsi()
        {
            return isi;
        }
        public bool addBeritatoDB()
        {
            Database db = new Database();
            string query = "INSERT INTO berita(judul,isi) VALUES('" + judul + "','" + isi + "')";
            bool i = db.CallnonQuery(query);
            return i;
        }
        public bool saveBeritatoDB()
        {
            Database db = new Database();
            string query = "UPDATE berita SET judul = '" + judul + "', isi = '" + isi + "' where id_berita = "+idNews;
            bool i = db.CallnonQuery(query);
            return i;
        }
        public bool deleteBeritafromDB()
        {
            Database db = new Database();
            string query = "DELETE FROM berita where id_berita = " + idNews;
            bool i = db.CallnonQuery(query);
            return i;
        }
    }
}
