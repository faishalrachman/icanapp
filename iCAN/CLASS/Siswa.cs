using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCAN.CLASS
{
    class Siswa : User
    {
        private String NIS;
        private Kelas kelas;

        public string NIS1 { get => NIS; set => NIS = value; }
        internal Kelas Kelas { get => kelas; set => kelas = value; }

        public Siswa(String NIS, int idUser, string nama) : base(idUser, nama)
        {
            this.NIS = NIS;
        }

        public void SetNIS(String NIS)
        {
            this.NIS = NIS;
        }

        public String GetNIS()
        {
            return this.NIS;
        }

    }
}

    

   
