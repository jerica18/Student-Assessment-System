using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scoring_And_Grading.Models;

namespace Scoring_And_Grading.Interfaces
{
        public interface IStudentExam
        {
            List<StudentExamReport> GetStudentExamReport(string subjectCode);
        }
}

