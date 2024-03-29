﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCAN.CLASS
{
    class M_Siswa : M_User
    {
        private String NIS;
        int jenis_kelamin;

        public int Jenis_kelamin
        {
            get { return jenis_kelamin; }
            set { jenis_kelamin = value; }
        }
        string nama_kelas;

        public string Nama_kelas
        {
            get { return nama_kelas; }
            set { nama_kelas = value; }
        }
        String tempat_lahir;

        public String Tempat_lahir
        {
            get { return tempat_lahir; }
            set { tempat_lahir = value; }
        }
        String tanggal_lahir;

        public String Tanggal_lahir
        {
            get { return tanggal_lahir; }
            set { tanggal_lahir = value; }
        }
        String agama;

        public String Agama
        {
            get { return agama; }
            set { agama = value; }
        }
        String alamat;

        public String Alamat
        {
            get { return alamat; }
            set { alamat = value; }
        }

        public String myNIS
        {
            get { return NIS; }
            set { NIS = value; }
        }

        private String idKelas;

        public String IdKelas
        {
            get { return idKelas; }
            set { idKelas = value; }
        }



        public M_Siswa(int idUser) : base(idUser)
        {
            Database db = new Database();
            db.reader = db.callQuery("SELECT * FROM v_siswa where id_user = "+idUser);
            if (db.reader.Read())
            {
                myNIS = db.reader.GetString("NIS");
                IdUser = Convert.ToInt32(db.reader.GetString("id_user"));
                string jk = db.reader.GetString("jenis_kelamin");
                if (jk == "True")
                    jenis_kelamin = 1;
                else
                    jenis_kelamin = 0;
                nama_kelas = db.reader.GetString("nama_kelas");
                this.tempat_lahir = db.reader.GetString("tempat_lahir");
                tanggal_lahir = db.reader.GetString("tanggal_lahir");
                agama = db.reader.GetString("agama");
                alamat = db.reader.GetString("alamat");
                idKelas = db.reader.GetString("id_kelas");
                db.databaseConnection.Close();
            }
            else
            {
                myNIS = null;
                IdUser = -1;
                Nama = null;
                jenis_kelamin = 0;
                nama_kelas = null;
                tempat_lahir = null;
                tanggal_lahir = null;
                agama = null;
                alamat = null;
                db.databaseConnection.Close();

            }
        }
        public bool deleteSiswafromDB()
        {
            bool i = deleteUserfromDB();
            if (i){
            Database db = new Database();
                i = db.CallnonQuery("DELETE FROM siswa WHERE id_user ="+IdUser);
            }
            return i;
        }
        public bool saveSiswatoDB()
        {
            
            saveUsertoDB();
            Database db = new Database();
            string idKelas = "";
                string query = "SELECT id_kelas from kelas where nama_kelas = '" + nama_kelas + "';";
                db.reader = db.callQuery(query);

                if (db.reader.Read())
                {
                    idKelas = db.reader.GetString(0);
                    db.Closedb();
                }

            query = "UPDATE siswa SET id_kelas = " + idKelas + ", tempat_lahir = '" + tempat_lahir + "', tanggal_lahir = '" + tanggal_lahir + "', agama = '" + agama + "', alamat = '"+alamat+"', jenis_kelamin = "+jenis_kelamin+" WHERE NIS = " + NIS + " ";
            bool i = db.CallnonQuery(query);
            return i;
        }
    }
}

    

   
