using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCAN.CLASS
{
    class M_Ekskul
    {
        private String idEkskul;

        public String IdEkskul
        {
            get { return idEkskul; }
            set { idEkskul = value; }
        }
        private String nama;

        public String Nama
        {
            get { return nama; }
            set { nama = value; }
        }
        private M_Siswa ketua;

        internal M_Siswa Ketua
        {
            get { return ketua; }
            set { ketua = value; }
        }

        public M_Ekskul(String idEkskul, String nama, M_Siswa ketua)
        {
            IdEkskul = idEkskul;
            Nama = nama;
            Ketua = ketua;
        }

    }
}
