using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Assessment_System.Models
{
    public class Student: User
    {
        public override string Role => "Student";
    }
}
