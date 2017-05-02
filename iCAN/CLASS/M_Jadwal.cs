using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCAN.CLASS
{
    class M_Jadwal 
    {
        private String idJadwal;
        private String jam;

        public String Jam
        {
            get { return jam; }
            set { jam = value; }
        }
        private String hari;

        public String Hari
        {
            get { return hari; }
            set { hari = value; }
        }
        private String ruangan;

        public String Ruangan
        {
            get { return ruangan; }
            set { ruangan = value; }
        }

        public M_Jadwal(String jam, String hari, String ruangan)
        {
            this.jam = jam;
            this.hari = hari;
            this.ruangan = ruangan;
            addtoDB();
        }
        public M_Jadwal(string id_jadwal)
        {
            Database db = new Database();
            db.reader = db.callQuery("SELECT * from jadwal where id_jadwal = " + id_jadwal);
            if (db.reader.Read())
            {
                this.jam = db.reader.GetString("jam");
                this.ruangan = db.reader.GetString("ruangan");
                this.hari = db.reader.GetString("hari");
            }
        }
        public M_Jadwal(String idJadwal, String jam, String hari, String ruangan)
        {
            this.idJadwal = idJadwal;
            this.jam = jam;
            this.hari = hari;
            this.ruangan = ruangan;

        }

        public String getId()
        {
            return idJadwal;
        }

        public bool addtoDB()
        {
            Database db = new Database();
            string query = "INSERT INTO jadwal(jam,hari,ruangan) VALUES('" + jam + "','" + hari + "','"+ruangan+"')";
            bool i = db.CallnonQuery(query);
            return i;
        }

        public bool savetoDB()
        {
            Database db = new Database();
            string query = "UPDATE jadwal SET jam = '" + jam + "', hari = '" + "', ruangan = '" + ruangan + "' where id_jadwal = " + idJadwal;
            bool i = db.CallnonQuery(query);
            return i;
        }
        public bool deletefromDB()
        {
            Database db = new Database();
            string query = "DELETE FROM jadwal where id_jadwal = " + idJadwal;
            bool i = db.CallnonQuery(query);
            return i;
        }
    }
}
