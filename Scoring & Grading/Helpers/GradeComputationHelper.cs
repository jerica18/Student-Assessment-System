using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoring___Grading.Helpers
{
    public class GradeComputationHelper
    {
        public decimal CalculatePercentage(int score, int totalItems)
        {
            if (totalItems <= 0) return 0;
            return (decimal)score / totalItems * 100;
        }

        public string GetLetterGrade(decimal percentage)
        {
            if (percentage >= 90) return "A";
            if (percentage >= 80) return "B";
            if (percentage >= 70) return "C";
            if (percentage >= 60) return "D";
            return "F";
        }

        public string GetRemarks(string letterGrade)
        {
            return letterGrade == "F" ? "Failed" : "Passed";
        }
    }
}