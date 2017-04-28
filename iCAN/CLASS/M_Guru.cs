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

        public string myNIP { get => NIP; set => NIP = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string No_hp { get => no_hp; set => no_hp = value; }
        public string IdGuru { get => idGuru; set => idGuru = value; }

        public M_Guru(int IdUser) : base(IdUser)
        {
            
            Database db = new Database();
            db.reader = db.callQuery("SELECT * from v_guru where id_user =" + IdUser);
            if (db.reader.Read())
            {
                myNIP = db.reader.GetString(2);
                Alamat = db.reader.GetString(4);
                No_hp = db.reader.GetString(5);
            }
        }
        public M_Guru(int idUser, String idGuru ,string nip, string nama, string alamat, string no_hp)
        {
            IdUser = idUser;
            IdGuru = idGuru;
            myNIP = nip;
            Nama = nama;
            Alamat = alamat;
            No_hp = no_hp;
        }

        public void SetNIP(String NIP)
        {
            this.myNIP = NIP;
        }

        public String GetNIP()
        {
            return this.myNIP;
        }

    }
}
