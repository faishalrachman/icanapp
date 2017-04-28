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
        

        public M_Guru(int IdUser) : base(IdUser)
        {
            
            Database db = new Database();
            db.reader = db.callQuery("SELECT NIP FROM guru where id_user = " + IdUser);
            if (db.reader.Read())
            {
                NIP = db.reader.GetString(0);
            }
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
