using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCAN.CLASS
{
    class Admin : User
    {
        private String idAdmin;
        

        public Admin(int IdUser, String nama, String password, String idAdmin) : base(IdUser,nama)
        {
            IdAdmin = idAdmin;
        }


        public String IdAdmin { get => idAdmin; set => idAdmin = value; }
    }
}
