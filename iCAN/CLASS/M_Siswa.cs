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
        bool jenis_kelamin;
        int idKelas;
        String tempat_lahir;
        String tanggal_lahir;
        String agama;
        String alamat;

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
        public M_Siswa(int idUser) : base()
        {
            Database db = new Database();
            db.reader = db.callQuery("SELECT * FROM v_siswa where id_user = "+idUser);
            if (db.reader.Read())
            {
                NIS1 = db.reader.GetString(0);
                IdUser = Convert.ToInt32(db.reader.GetString(1));
                Nama = db.reader.GetString(2);
                if (db.reader.GetString(3) == "1")
                    jenis_kelamin = true;
                else
                    jenis_kelamin = false;
                tempat_lahir = db.reader.GetString(5);
                tanggal_lahir = db.reader.GetString(6);
                agama = db.reader.GetString(7);
                alamat = db.reader.GetString(8);
                db.databaseConnection.Close();
            }
        }
        public M_Siswa() : base()
        {

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

    

   
