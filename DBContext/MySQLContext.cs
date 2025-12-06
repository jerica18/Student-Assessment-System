using Student_Assessment_System.Interface;
using Student_Assessment_System.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Assessment_System.DBContext
{
    public class MySQLContext : IAdmin
    {
        private string _conStr = Helpers.MySqlHelper.GetConnectionString();
        public List<Student> GetCourseList(int id, string Scourse)
        {
            throw new NotImplementedException();
        }

    }
}
