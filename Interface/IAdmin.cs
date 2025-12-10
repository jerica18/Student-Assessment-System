using Student_Assessment_System.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Assessment_System.Interface
{
    public interface IAdmin
    {
        List<Student> GetCourseList(int id, string Scourse);
    }
}
