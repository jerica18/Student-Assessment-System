using Scoring___Grading.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoring___Grading.Helpers
{
    public class ScoringHelper : IScoringService
    {
        public double CalculateRawScore(int correctAnswers, int totalQuestions)
        {
            return correctAnswers;
        }

        public double CalculatePercentage(double rawScore, int totalQuestions)
        {
            return (rawScore / totalQuestions) * 100;
        }

        public string ApplyGradingScale(double percentage)
        {
            if (percentage >= 90) return "A";
            if (percentage >= 80) return "B";
            if (percentage >= 70) return "C";
            if (percentage >= 60) return "D";
            return "F";
        }

        public double CalculateRawScore(int correctAnswers)
        {
            throw new NotImplementedException();
        }
    }
}