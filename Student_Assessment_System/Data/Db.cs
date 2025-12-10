using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Student_Assessment_System.Data
{
    public class Db
    {
        private readonly MySqlConnection connection;
        private string conn;

        public Db()
        {
            connection = new MySqlConnection(
                "server=localhost;database=student_assessment_db;uid=root;pwd=;");
        }
        public Db(string conn)
        {
            this.conn = conn;
            connection = new MySqlConnection(conn);
        }

        public MySqlConnection GetConnection() => connection;

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
        public bool ExecuteProcedure(string procedureName, MySqlParameter[] parameters)
        {
            try
            {
                this.Open();
                using (MySqlCommand cmd = new MySqlCommand(procedureName, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                this.Close();
            }
        }
    }
}