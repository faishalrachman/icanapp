using System;
using System.Windows;

namespace iCAN
{
    class login
    {
       private string username,password;
        Database db;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public login(string username, string password)
        {
            Username = username;
            Password = password;
            db = new Database();
        }
        public bool check_login()
        {
            try
            {
                db.reader = db.callQuery("SELECT * FROM user where username = 'admin'");
                if (db.reader.HasRows)
                {
                    MessageBox.Show("Login Sukses");
                    return true;
                }
                else
                {
                    MessageBox.Show("Login Sakit Perut");
                    return false;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error Anyeng");
            }
            return false;
        }
    }
}
