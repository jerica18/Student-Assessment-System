using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoring___Grading.Interfaces
{
    public interface IScoringService
    {
        double CalculateRawScore(int correctAnswers);
        double CalculatePercentage(double rawScore, int totalQuestions);
    }
}