using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCAN.CLASS
{
    class M_Guru : M_User
    {
        private String idGuru;
        private String NIP;
        private String alamat;
        private String no_hp;

        public string myNIP { get { return NIP; } set { NIP = value; } }
        public string Alamat { get { return alamat; } set { alamat = value; } }
        public string No_hp { get { return no_hp; } set { no_hp = value; } }
        public string IdGuru { get { return idGuru; } set { idGuru = value; } }

        public M_Guru(int idUser) : base(idUser)
        {

            Database db = new Database();
            db.reader = db.callQuery("SELECT * from v_guru where id_user =" + idUser);
            if (db.reader.Read())
            {
                myNIP = db.reader.GetString(2);
                Alamat = db.reader.GetString(4);
                No_hp = db.reader.GetString(5);
            }
        }
        public M_Guru(int idUser, String idGuru, string nip, string nama, string alamat, string no_hp)
        {
            IdUser = idUser;
            IdGuru = idGuru;
            myNIP = nip;
            Nama = nama;
            Alamat = alamat;
            No_hp = no_hp;
        }
        public M_Guru() { }

        public void SetNIP(String NIP)
        {
            this.myNIP = NIP;
        }

        public String GetNIP()
        {
            return this.myNIP;
        }

        public bool deleteGurufromDB()
        {
            Database db = new Database();
            bool i = db.CallnonQuery("DELETE FROM guru where id_user =" + IdUser);
            idGuru = "";
            NIP = "";
            alamat = "";
            no_hp = "";
            return i;
        }
        public bool saveGurutoDB()
        {
            saveUsertoDB();
            Database db = new Database();
            bool i = db.CallnonQuery("UPDATE guru SET alamat = '" + Alamat + "', no_hp = '" + No_hp + "' where id_user = "+IdUser);
            return i;
        }

        public bool addGurutoDB()
        {
            Role = "guru";
            addUsertoDB();
            Database db = new Database();
            string query = "INSERT INTO guru(id_user,NIP,alamat,no_hp) VALUES('" + IdUser + "','" + myNIP + "','" + Alamat + "','" + No_hp + "')";
            bool i = db.CallnonQuery(query);
            return i;
        }

    }
}
