using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCAN.CLASS
{
    class M_Admin : M_User
    {

        public M_Admin(int idUser) : base()
        {
            Database db = new Database();
            db.reader = db.callQuery("SELECT * FROM user where id=" + idUser + ";");
            if (db.reader.Read())
            {
                Nama = db.reader.GetString("nama");
            }
            
        }


    }
}
