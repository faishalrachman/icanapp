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
        private String jam;
        private String hari;
        private String nama_guru;
        private String ruangan;




        public M_Mapel(String kdMapel, String nmMapel, String jam, string hari, String nama_guru, string ruangan)
        {
            this.kdMapel = kdMapel;
            this.nmMapel = nmMapel;
            this.jam = jam;
            this.hari = hari;
            this.nama_guru = nama_guru;
            this.ruangan = ruangan;
        }
        public M_Mapel() { }

        public void setNama(String Nama)
        {
            this.nmMapel = Nama;
        }

        public String getNama()
        {
            return this.nmMapel;
        }

        //public void addJadwal(M_Jadwal jd)
        //{
        //    if (JadwalP.Length < 100)
        //    {
        //        this.jumlah++;
        //        this.JadwalP[this.jumlah] = jd;
        //    }
        //    //else
        //        //System.out.println("Jadwal Penuh");
        //}

        //public M_Jadwal carJadwal(String idJadwal)
        //{
        //    for (int i = 0; i <= this.jumlah; i++)
        //    {
        //        if (this.JadwalP[i].getId() == idJadwal)
        //            return this.JadwalP[i];
        //    }
        //    return null;
        //}

        //public M_Jadwal removeJadwal(String idJadwal)
        //{
        //    M_Jadwal j = null;
        //    for (int i = 0; i <= this.jumlah; i++)
        //    {
        //        if (this.JadwalP[i].getId() == idJadwal)
        //        {
        //            j = JadwalP[i];
        //            this.JadwalP[i] = null;
        //        }

        //    }
        //    return j;
        //}
    }
}
