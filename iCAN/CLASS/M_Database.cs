﻿using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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
            try
            {
                MySqlDataReader reader;
                databaseConnection.Close();
                databaseConnection.Open();
                commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                reader = commandDatabase.ExecuteReader();
                return reader;

            }
            catch (Exception)
            {

                MessageBox.Show("Cant connect to database");
                return reader;
            }
        }
        public DataTable callQuerytoDataTable(string query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                databaseConnection.Close();
                databaseConnection.Open();
                commandDatabase = new MySqlCommand(query, databaseConnection);
                MySqlDataAdapter da = new MySqlDataAdapter(commandDatabase);
                da.Fill(dataTable);
                return dataTable;

            }
            catch (Exception)
            {

                MessageBox.Show("Cant connect to database");
                return dataTable;
            }
        }
        public bool CallnonQuery(string query)
        {
            try
            {
                int reader;
                databaseConnection.Close();
                databaseConnection.Open();
                commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                reader = commandDatabase.ExecuteNonQuery();
                if (reader > 0)
                {
                    databaseConnection.Close();
                    return true;
                }
                else
                    return false;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public void Closedb()
        {
            
            databaseConnection.Close();
        }
        public String escapeString(String s)
        {
            return MySqlHelper.EscapeString(s);
        }
        

    }
}
