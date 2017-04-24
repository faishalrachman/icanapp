using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace iCAN
{
    class Database
    {
        private string server = "localhost";
        private string username = "root";
        private string password = "";
        private string port = "3306";
        private string dbname = "ican";
        private string connectionString;
        public MySqlConnection databaseConnection;
        public MySqlCommand commandDatabase;
        public MySqlDataReader reader;

        public Database()
        {
            connectionString = "datasource=" + server + ";port=" + port + ";username=" + username + ";password=" + password + ";database=" + dbname + ";";
            databaseConnection = new MySqlConnection(connectionString);

        }
        public MySqlDataReader callQuery(string query)
        {
                MySqlDataReader reader;
                databaseConnection.Open();
                commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                reader = commandDatabase.ExecuteReader();
                return reader;
        }

    }
}
