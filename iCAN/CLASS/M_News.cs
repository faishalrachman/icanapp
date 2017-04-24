using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCAN.CLASS
{
    class M_News
    {
        public int idNews;
        public String judul;
        public String isi;

        public M_News(int idNews, String judul, String isi)
        {
            this.idNews = idNews;
            this.judul = judul;
            this.isi = isi;
        }

        public void setJudul(String judul)
        {
            this.judul = judul;
        }

        public String getJudul()
        {
            return this.judul;
        }

        public void setIsi(String Isi)
        {
            this.isi = isi;
        }

        public String getIsi()
        {
            return this.isi;
        }
    }
}
