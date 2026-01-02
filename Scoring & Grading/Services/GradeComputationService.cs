using Scoring___Grading.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoring___Grading.Services
{
    public class GradeComputationService : IGradeComputationService
    {
        public double CalculateWeightedScore(double score, double weight)
        {
            return score * weight;
        }

        public string ConvertToLetterGrade(double percentage)
        {
            if (percentage >= 90) return "A";
            if (percentage >= 80) return "B";
            if (percentage >= 70) return "C";
            if (percentage >= 60) return "D";
            return "F";
        }
    }
}