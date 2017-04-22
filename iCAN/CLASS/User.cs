using MySql.Data.MySqlClient;
using System;
using System.Windows;

namespace iCAN.CLASS
{
    class User
    {
        private int idUser;
        private String nama;
        private String role;

        public string Nama { get => nama; set => nama = value; }
        public int IdUser { get => idUser; set => idUser = value; }
        public string Role { get => role; set => role = value; }

        public User(int idUser, String nama)
        {
            IdUser = idUser;
            Nama = nama;
        }
        public User()
        {

        }
        public bool check_login(String username, String password)
        {
            Database db = new Database();
            string query = "SELECT * FROM user where username = '" + username.Remove(username.Length - 2) + "'";
            MessageBox.Show(query);
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
