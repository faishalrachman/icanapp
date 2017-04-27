using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCAN.CLASS
{
    class M_Guru : M_User
    {

        private String NIP;
        

        public M_Guru(int IdUser, String nama, String password, String NIP) : base(IdUser)
        {

            Database db = new Database();
            db.callQuery("SELECT NIP FROM guru where id_user = " + IdUser);
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
