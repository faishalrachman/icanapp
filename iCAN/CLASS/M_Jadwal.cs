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
        public DateTime tanggal;
        public String ruangan;

        public M_Jadwal(String idJadwal, DateTime tanggal, String ruangan)
        {
            this.idJadwal = idJadwal;
            this.ruangan = ruangan;
            this.tanggal = tanggal;
        }

        public String getId()
        {
            return idJadwal;
        }
    }
}
