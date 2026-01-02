using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoring___Grading.Models
{
    public class StudentExamReport
    {
        public int StudentId { get; set; }
        public string ExamName { get; set; }
        public string SubjectCode { get; set; }
        public int TotalCorrect { get; set; }
        public double Percentage { get; set; }
        public string LetterGrade { get; set; }
    }
}