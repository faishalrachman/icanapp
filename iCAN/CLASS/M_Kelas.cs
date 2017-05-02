using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace iCAN.CLASS
{
    class M_Kelas
    {
        private String idKelas;

        public String IdKelas
        {
            get { return idKelas; }
            set { idKelas = value; }
        }
        private String nama_kelas;

        public String Nama_kelas
        {
            get { return nama_kelas; }
            set { nama_kelas = value; }
        }
        private String nama_wali;

        public String Nama_wali
        {
            get { return nama_wali; }
            set { nama_wali = value; }
        }

        public M_Kelas(string idKelas, string nama_kelas, String nama_wali)
        {
            this.idKelas = idKelas;
            this.nama_kelas = nama_kelas;
            this.nama_wali = nama_wali;
        }
        public M_Kelas(string idKelas)
        {
            Database db = new Database();
            db.reader = db.callQuery("SELECT * FROM v_kelas where id_kelas =" + idKelas);
            if (db.reader.Read())
            {
                this.nama_kelas = db.reader.GetString("nama_kelas");
                this.nama_wali = db.reader.GetString("nama_guru");
            }
        }
        public M_Kelas(string nama_kelas, string nama_wali)
        {
            this.nama_kelas = nama_kelas;
            this.nama_wali = nama_wali;
        }

        //public M_Kelas(String Name, int SiswaMax)
        //{
        //    this.NmKelas = Name;
        //    this.SiswaMax = SiswaMax;
        //    this.siswa = new M_Siswa[SiswaMax];
        //}

        //public void AddSiswa(M_Siswa Anak)
        //{
        //    if (this.JumlahSiswa < this.SiswaMax)
        //    {
        //        this.siswa[this.JumlahSiswa] = Anak;
        //        this.JumlahSiswa++;
        //    }
        //    else
        //        MessageBox.Show("Siswa Sudah Penuh");
        //}

        //public M_Siswa RemoveSiswa(String Name)
        //{
        //    M_Siswa s = null;
        //    for (int i = 0; i <= this.JumlahSiswa; i++)
        //    {
        //        if (this.siswa[i].Nama == Name)
        //        {
        //            s = this.siswa[i];
        //            for (int j = i; j < this.JumlahSiswa - 1; j++)
        //                this.siswa[j] = this.siswa[j + 1];
        //        }
        //    }
        //    return s;
        //}

        //public void SetWali(M_Guru Gr)
        //{
        //    this.Gr = Gr;
        //}

        //public M_Guru GetWali()
        //{
        //    return this.Gr;
        //}

        //public void LihatSiswa()
        //{
        //    if (JumlahSiswa != 0)
        //    {
        //        for (int i = 0; i < this.JumlahSiswa; i++)
        //        {
        //            //System.OutOfMemoryException.println("Nama Siswa : " + this.siswa[i].GetName());
        //            //System.out.println("NIS Siswa : " + this.siswa[i].GetNIS());
        //        }
        //    }
        //    //else
        //        //System.out.println("Tidak ada siswa");
        //}
    }
}
