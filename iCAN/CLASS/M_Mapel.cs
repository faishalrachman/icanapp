using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCAN.CLASS
{
    class M_Mapel
    {
        //id_jadwal 	id_kelas 	id_guru 	id_mapel 	nama_mapel 	id_user 	NIP 	nama 	jam 	hari 	ruangan 	2 	2 	4 	1 	Matematika 	17 	22 	1313 	06:30:00 	Selasa X IPA 1

        private String kdMapel;
        private String nmMapel;
        private M_Jadwal[] JadwalP = new M_Jadwal[100];
        private M_Nilai[] nilaiMapel;
        private M_Guru gr;
        private int jumlah = 0;



        public M_Mapel(String kode, String nama)
        {
            this.kdMapel = kode;
            this.nmMapel = nama;
            this.nilaiMapel = new M_Nilai[10];
        }

        public void setNama(String Nama)
        {
            this.nmMapel = Nama;
        }

        public String getNama()
        {
            return this.nmMapel;
        }

        public void addJadwal(M_Jadwal jd)
        {
            if (JadwalP.Length < 100)
            {
                this.jumlah++;
                this.JadwalP[this.jumlah] = jd;
            }
            //else
                //System.out.println("Jadwal Penuh");
        }

        public M_Jadwal carJadwal(String idJadwal)
        {
            for (int i = 0; i <= this.jumlah; i++)
            {
                if (this.JadwalP[i].getId() == idJadwal)
                    return this.JadwalP[i];
            }
            return null;
        }

        public M_Jadwal removeJadwal(String idJadwal)
        {
            M_Jadwal j = null;
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
