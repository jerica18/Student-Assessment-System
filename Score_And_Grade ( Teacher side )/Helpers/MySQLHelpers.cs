using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Score_And_Grade___Teacher_side__.Helpers
{
    public class MySQLHelpers
    {
        public static string GetConnectionString() 
        {
            return ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
        }
    }
}
