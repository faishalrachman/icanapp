using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCAN.CLASS
{
    class M_Admin : M_User
    {
        private String idAdmin;

        public String IdAdmin
        {
            get { return idAdmin; }
            set { idAdmin = value; }
        }
        

        public M_Admin(int IdUser, String nama, String password, String idAdmin) : base(IdUser,nama)
        {
            IdAdmin = idAdmin;
        }


    }
}
