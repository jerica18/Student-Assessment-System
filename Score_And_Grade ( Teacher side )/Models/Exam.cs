using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Score_And_Grade___Teacher_side__.Models
{
    public class Exam
    {
        public int ExamId { get; set; }
        public string ExamName { get; set; }
        public string ExamType { get; set; }
        public int AssignmentId { get; set; }
        public decimal PassingScore { get; set; }
        public DateTime StartTime { get; set; }
        public List<Question> Questions { get; set; } = new List<Question>();
    }
}
