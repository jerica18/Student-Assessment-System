using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Student_Assessment_System.Data
{
    public class Db
    {
        private readonly MySqlConnection connection;
        private string conn;

        public Db()
        {
            connection = new MySqlConnection(
                "server=localhost;database=test;uid=root;pwd=;");
        }

        public Db(string conn)
        {
            this.conn = conn;
        }

        public MySqlConnection GetConnection() => connection;

        public void Open() { if (connection.State == System.Data.ConnectionState.Closed) connection.Open(); }

        public void Close() { if (connection.State == System.Data.ConnectionState.Open) connection.Close(); }
    }
}
