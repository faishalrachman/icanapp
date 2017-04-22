using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace iCAN.CLASS
{
    class Kelas
    {
        private String NmKelas;
        private int JumlahSiswa = 0;
        private int SiswaMax;
        private Siswa[] siswa;
        private Guru Gr;

        public Kelas(String Name, int SiswaMax)
        {
            this.NmKelas = Name;
            this.SiswaMax = SiswaMax;
            this.siswa = new Siswa[SiswaMax];
        }

        public void AddSiswa(Siswa Anak)
        {
            if (this.JumlahSiswa < this.SiswaMax)
            {
                this.siswa[this.JumlahSiswa] = Anak;
                this.JumlahSiswa++;
            }
            else
                MessageBox.Show("Siswa Sudah Penuh");
        }

        public Siswa RemoveSiswa(String Name)
        {
            Siswa s = null;
            for (int i = 0; i <= this.JumlahSiswa; i++)
            {
                if (this.siswa[i].Nama == Name)
                {
                    s = this.siswa[i];
                    for (int j = i; j < this.JumlahSiswa - 1; j++)
                        this.siswa[j] = this.siswa[j + 1];
                }
            }
            return s;
        }

        public void SetWali(Guru Gr)
        {
            this.Gr = Gr;
        }

        public Guru GetWali()
        {
            return this.Gr;
        }

        public void LihatSiswa()
        {
            if (JumlahSiswa != 0)
            {
                for (int i = 0; i < this.JumlahSiswa; i++)
                {
                    //System.OutOfMemoryException.println("Nama Siswa : " + this.siswa[i].GetName());
                    //System.out.println("NIS Siswa : " + this.siswa[i].GetNIS());
                }
            }
            //else
                //System.out.println("Tidak ada siswa");
        }
    }
}
