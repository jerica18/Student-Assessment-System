using Scoring___Grading.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoring___Grading.Services
{
    public class ScoringService : IScoringService
    {
        public double CalculateRawScore(int correctAnswers)
        {
            return correctAnswers;
        }

        public double CalculatePercentage(double rawScore, int totalQuestions)
        {
            if (totalQuestions == 0) return 0;
            return (rawScore / totalQuestions) * 100;
        }
    }
}