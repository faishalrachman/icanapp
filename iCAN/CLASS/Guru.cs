using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCAN.CLASS
{
    class Guru : User
    {

        private String NIP;
        

        public Guru(int IdUser, String nama, String password, String NIP) : base(IdUser, nama)
        {
        
            this.NIP = NIP;
            
        }


        public void SetNIP(String NIP)
        {
            this.NIP = NIP;
        }

        public String GetNIP()
        {
            return this.NIP;
        }

    }
}
