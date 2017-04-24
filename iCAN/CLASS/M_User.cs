using MySql.Data.MySqlClient;
using System;
using System.Windows;

namespace iCAN.CLASS
{
    class M_User
    {
        private int idUser;
        private String nama;
        private String role;
	

        public string Nama { get { return nama;} set {nama = value;} }
        public int IdUser { get { return idUser;} set {idUser = value;}}
        public string Role { get { return role; } set { role = value; } }

        public M_User(int idUser, String nama)
        {
            IdUser = idUser;
            Nama = nama;
        }
        public M_User()
        {

        }
        public bool check_login(String username, String password)
        {
            Database db = new Database();
            string query = "SELECT * FROM user where username = '" + username + "'";
            db.reader = db.callQuery(query);
            
            if (db.reader.Read())
            {
                    IdUser = db.reader.GetInt32(0);
                    Nama = db.reader.GetString(3);
                    Role = db.reader.GetString(4);
                    return true;
            }
            else
            {
                return false;
            }
            return false;
        }
        
    }
}
