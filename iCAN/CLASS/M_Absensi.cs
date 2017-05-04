using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCAN.CLASS
{
    class M_Absensi
    {
        public string id_absensi;
        public string NIS;
        public string id_mapel;
        public int status;
        public M_Absensi(string id_absensi)
        {

        }
        public M_Absensi(string id_absensi, string NIS, string id_mapel)
        {
            this.id_absensi = id_absensi;
            this.NIS = NIS;
            this.id_mapel = id_mapel;
        }
    }
}
