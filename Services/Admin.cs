using Student_Assessment_System.Course___Subject;
using Student_Assessment_System.Interface;
using Student_Assessment_System.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZstdSharp.Unsafe;

namespace Student_Assessment_System.Services
{
    public class Admin
    {
        private IAdmin _repo;

        public Admin(IAdmin repo)
        {
            _repo = repo;
        }

        public List<Student> GetAllCourse(int id, string Scourse)
        {
            return _repo.GetCourseList(id, Scourse);
        }
    }
}
