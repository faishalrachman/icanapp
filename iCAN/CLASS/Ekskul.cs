using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCAN.CLASS
{
    class Ekskul
    {
        private String idEkskul;
        private String nama;
        private Siswa ketua;

        public Ekskul(String idEkskul, String nama, Siswa ketua)
        {
            IdEkskul = idEkskul;
            Nama = nama;
            Ketua = ketua;
        }

        public string IdEkskul { get => idEkskul; set => idEkskul = value; }
        public string Nama { get => nama; set => nama = value; }
        internal Siswa Ketua { get => ketua; set => ketua = value; }
    }
}
