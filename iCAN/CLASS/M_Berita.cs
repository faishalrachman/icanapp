using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCAN.CLASS
{
    class M_Berita
    {
        public int idNews;
        public String judul;
        public String isi;
        public int status;
        private Database db;

        public M_Berita(int idNews, String judul, String isi)
        {
            this.idNews = idNews;
            this.judul = judul;
            this.isi = isi;
        }
        public M_Berita(int idNews)
        {
            db = new Database();
            db.reader = db.callQuery("SELECT * from berita where id_berita = "+idNews);
            if (db.reader.Read())
            {
                judul = db.reader.GetString(1);
                isi = db.reader.GetString(2);
                status = Convert.ToInt32(db.reader.GetString(3));
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
    }
}
