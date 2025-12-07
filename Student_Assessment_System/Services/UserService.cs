using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_Assessment_System.Data;
using Student_Assessment_System.Models;
using MySql.Data.MySqlClient;


namespace Student_Assessment_System.Services
{
    public class UserService
    {
        private readonly Db _db;


        public UserService(Db db)
        {
            _db = db;
        }
        public User Authenticate(string username, string passwordStrong)
        {
            try
            {
                _db.Open();

                string sql = @"
                SELECT user_id, username, role, fullname
                FROM users
                WHERE username=@u
                AND password=SHA2(@p,256)
                AND status='Active'";

                using (var cmd = new MySqlCommand(sql, _db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@u", username ?? string.Empty);
                    cmd.Parameters.AddWithValue("@p", passwordStrong ?? string.Empty);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                            return null;

                        int ordId = reader.GetOrdinal("user_id");
                        int ordUsername = reader.GetOrdinal("username");
                        int ordRole = reader.GetOrdinal("role");
                        int ordFullname = reader.GetOrdinal("fullname");

                        string roleValue = reader.IsDBNull(ordRole) ? string.Empty : reader.GetString(ordRole);

                        User user = null;
                        if (string.Equals(roleValue, "Admin", StringComparison.OrdinalIgnoreCase))
                        {
                            user = new Admin();
                        }
                        else if (string.Equals(roleValue, "Teacher", StringComparison.OrdinalIgnoreCase))
                        {
                            user = new Teacher();
                        }
                        else if (string.Equals(roleValue, "Student", StringComparison.OrdinalIgnoreCase))
                        {
                            user = new Student();
                        }
                        else
                        {
                            return null;
                        }

                        void SetIfExists(object target, string propName, object value)
                        {
                            if (target == null) return;
                            var pi = target.GetType().GetProperty(propName,
                                System.Reflection.BindingFlags.Public |
                                System.Reflection.BindingFlags.Instance |
                                System.Reflection.BindingFlags.IgnoreCase);
                            if (pi != null && pi.CanWrite)
                            {
                                if (value == null || value is DBNull) return;
                                object converted = value;
                                try
                                {
                                    if (pi.PropertyType.IsEnum)
                                        converted = Enum.ToObject(pi.PropertyType, value);
                                    else if (pi.PropertyType != value.GetType())
                                        converted = Convert.ChangeType(value, pi.PropertyType);
                                }
                                catch
                                {

                                }
                                pi.SetValue(target, converted);
                            }
                        }

                        SetIfExists(user, "Id", reader.IsDBNull(ordId) ? 0 : reader.GetInt32(ordId));
                        SetIfExists(user, "id", reader.IsDBNull(ordId) ? 0 : reader.GetInt32(ordId));
                        SetIfExists(user, "Username", reader.IsDBNull(ordUsername) ? string.Empty : reader.GetString(ordUsername));
                        SetIfExists(user, "username", reader.IsDBNull(ordUsername) ? string.Empty : reader.GetString(ordUsername));
                        SetIfExists(user, "FullName", reader.IsDBNull(ordFullname) ? string.Empty : reader.GetString(ordFullname));
                        SetIfExists(user, "Fullname", reader.IsDBNull(ordFullname) ? string.Empty : reader.GetString(ordFullname));

                        return user;
                    }
                }
            }
            finally
            {
                _db.Close();
            }
        }
        public bool CreateUser(string username, string passwordPlain, string role, string fullname)
        {
            try
            {
                _db.Open();
                string sql = "INSERT INTO users (username, password, role, fullname) VALUES (@u, SHA2(@p,256), @r, @f)";
                using (var cmd = new MySqlCommand(sql, _db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", passwordPlain);
                    cmd.Parameters.AddWithValue("@r", role);
                    cmd.Parameters.AddWithValue("@f", fullname);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            finally
            {
                _db.Close();
            }
        }
    }
}