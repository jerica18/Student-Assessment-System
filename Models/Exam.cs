using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Assessment_System.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public string Title { get; set; }
        public int TimeLimit { get; set; }
        public DateTime Schedule { get; set; }
    }
}
