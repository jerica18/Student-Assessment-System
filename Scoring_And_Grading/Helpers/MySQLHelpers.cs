using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoring_And_Grading.Helpers
{
    public static class MySQLHelpers
    {
        public static string GetConnectionString() 
        {
            return ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
        }
    }
}