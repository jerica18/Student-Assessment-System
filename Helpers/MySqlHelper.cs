using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Assessment_System.Helpers
{
    public class MySqlHelper
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings
                ["MySQLConnection"].ConnectionString;
        }

        

    }
}
