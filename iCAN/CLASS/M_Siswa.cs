using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCAN.CLASS
{
    class M_Siswa : M_User
    {
        private String NIS;

        public String NIS1
        {
            get { return NIS; }
            set { NIS = value; }
        }

        private M_Kelas kelas;

        internal M_Kelas Kelas
        {
            get { return kelas; }
            set { kelas = value; }
        }


        public M_Siswa(String NIS, int idUser, string nama) : base(idUser, nama)
        {
            this.NIS = NIS;
        }

        public void SetNIS(String NIS)
        {
            this.NIS1 = NIS;
        }

        public String GetNIS()
        {
            return this.NIS1;
        }

    }
}

    

   
