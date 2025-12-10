using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Assessment_System.Course___Subject
{
    public abstract class Subject
    {
        protected int SubjectID;
        public string Subject_name { get; set; }
        public string Subject_code {  get; set; }
        public string status { get; set; }
    }
}
