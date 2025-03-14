using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Data;
using MySql.Data.MySqlClient;

namespace BazyDanychBadminton._03_Persistance
{
    class DBBroker
    {
        private static string _connectionString;
        private static MySqlConnection _connection;
        private static DBBroker _instance;
        private DBBroker()
        {
            DBBroker._connectionString = "server=localhost;database=Badminton;uid=root;pwd=admin;CharSet=utf8;";
            DBBroker._connection = new MySqlConnection(DBBroker._connectionString);
        }
        public static DBBroker getInstance()
        {
            if (DBBroker._instance == null)
            { 
                DBBroker._instance = new DBBroker();
            }
            return DBBroker._instance;
        }
        public List<string[]> Read(string sql)
            //SELECT
        {
            List<string[]> result = new List<string[]>();
            MySqlCommand commmand = new MySqlCommand(sql, DBBroker._connection);
            this.connect();
            MySqlDataReader reader = commmand.ExecuteReader();
            while (reader.Read())
            {
                string[] row = new string[reader.FieldCount];
                for(int i = 0; i < reader.FieldCount; i++)
                {
                    row[i]= reader[i].ToString();
                }
                result.Add(row);
            }
            reader.Close();
            this.disconnect();

            return result;
        }
        public int Change(string sql)
            //INSERT, UPDATE, DELETE
        { 
            MySqlCommand command = new MySqlCommand(sql, DBBroker._connection);
            int result;
            this.connect();
            result = command.ExecuteNonQuery();
            this.disconnect();
            return result;
        }
        public void connect()
        {
            if (DBBroker._connection != null && DBBroker._connection.State == ConnectionState.Closed)
            {
                DBBroker._connection.Open();
            }
        }
        public void disconnect() 
        {
            if (DBBroker._connection != null && DBBroker._connection.State == ConnectionState.Open)
            {
                DBBroker._connection.Close();
            }
        }

    }
}
