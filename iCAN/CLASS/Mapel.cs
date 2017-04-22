using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCAN.CLASS
{
    class Mapel
    {
        private String kdMapel;
        private String nmMapel;
        private Jadwal[] JadwalP = new Jadwal[100];
        private Nilai[] nilaiMapel;
        private Guru gr;
        private int jumlah = 0;

        public Mapel(String kode, String nama)
        {
            this.kdMapel = kode;
            this.nmMapel = nama;
            this.nilaiMapel = new Nilai[10];
        }

        public void setNama(String Nama)
        {
            this.nmMapel = Nama;
        }

        public String getNama()
        {
            return this.nmMapel;
        }

        public void addJadwal(Jadwal jd)
        {
            if (JadwalP.Length < 100)
            {
                this.jumlah++;
                this.JadwalP[this.jumlah] = jd;
            }
            //else
                //System.out.println("Jadwal Penuh");
        }

        public Jadwal carJadwal(String idJadwal)
        {
            for (int i = 0; i <= this.jumlah; i++)
            {
                if (this.JadwalP[i].getId() == idJadwal)
                    return this.JadwalP[i];
            }
            return null;
        }

        public Jadwal removeJadwal(String idJadwal)
        {
            Jadwal j = null;
            for (int i = 0; i <= this.jumlah; i++)
            {
                if (this.JadwalP[i].getId() == idJadwal)
                {
                    j = JadwalP[i];
                    this.JadwalP[i] = null;
                }

            }
            return j;
        }
    }
}
