using MySql.Data.MySqlClient;
using System;
using System.Windows;

namespace iCAN.CLASS
{
    class M_User
    {
        private int idUser;
        private String username, password;

        public String Username
        {
            get { return username; }
            set { username = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        private String nama;
        private String role;
	

        public string Nama { get { return nama;} set {nama = value;} }
        public int IdUser { get { return idUser;} set {idUser = value;}}
        public string Role { get { return role; } set { role = value; } }

        public M_User(int idUser)
        {
            Database db = new Database();
            string query = "SELECT * FROM user where id = " + idUser;
            db.reader = db.callQuery(query);
            if (db.reader.Read())
            {
                //1 admin 123456 Faishal Rachman admin
                Nama = db.reader.GetString(3);
                Role = db.reader.GetString(4);
                username = db.reader.GetString(1);
                password = db.reader.GetString(2);
            }
        }
        public M_User()
        {

        }
        public M_User(string username, string password, string nama, string role)
        {
            var db = new Database();
            bool i = db.CallnonQuery("INSERT INTO user (username,password,nama,role) VALUES ('"+username+"','"+password+"','"+nama+"','"+role+"')");

            if (i)
            {
                db.reader = db.callQuery("SELECT * from user where username='" + username + "'");
                if (db.reader.Read())
                {
                    IdUser = Convert.ToInt32(db.reader.GetString(0));
                    username = db.reader.GetString(1);
                    password = db.reader.GetString(2);
                    role = db.reader.GetString(3);
                }
            }
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
                db.databaseConnection.Close();
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public bool deleteUserfromDB()
        {
            Database db = new Database();
            bool i = db.CallnonQuery("DELETE FROM user where id =" + idUser);
            IdUser = -1;
            Nama = null;
            Role = null;
            Username = null;
            Password = null;
            return i;
        }
        public bool saveUsertoDB()
        {
            Database db = new Database();
            bool i = db.CallnonQuery("UPDATE user SET password = '"+password+"', nama = '"+nama+"', role = '"+role+"' where id = "+idUser);
            return i;
        }
    }
}
