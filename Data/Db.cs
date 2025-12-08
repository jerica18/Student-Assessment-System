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
        private MySqlConnection connection;

        public Db(string conn)
        {
            connection = new MySqlConnection(
                        "server=localhost;" +
                        "userid=root;" +
                        "password=moriahperez16!;" +
                        "database=student_assessment_db");
        }

        public void Open()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void Close()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}