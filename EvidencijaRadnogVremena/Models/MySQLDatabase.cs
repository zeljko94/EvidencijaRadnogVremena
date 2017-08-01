using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeopleCounterNg.Models
{
    public class MySQLDatabase
    {
        public MySqlConnection conn;


        public void ConnectToKnokErp()
        {
            this.conn = new MySql.Data.MySqlClient.MySqlConnection("Persist Security Info=True;server=77.78.200.66;database=knok_erp;uid=peoplecounter01;password=peoplecounter01!;old guids=true;");
            this.conn.Open();
        }

        public void ConnectToCustomCount()
        {
            this.conn = new MySql.Data.MySqlClient.MySqlConnection("Persist Security Info=True;server=77.78.200.66;database=custcount;uid=peoplecounter01;password=peoplecounter01!;old guids=true;");
            this.conn.Open();
        }

        public MySqlDataReader ExecuteStoredProcedure(string sql, Dictionary<string, object> args)
        {
            MySqlCommand cmd = this.conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            foreach (KeyValuePair<string, object> entry in args)
            {
                cmd.Parameters.AddWithValue(entry.Key, entry.Value);
            }

            //this.conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public MySqlDataReader Query(string sql, string operation, List<object> args)
        {
            return null;
        }

        public void CloseConnection()
        {
            this.conn.Close();
        }
    }
}