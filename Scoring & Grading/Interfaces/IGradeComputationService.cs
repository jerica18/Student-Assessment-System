using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoring___Grading.Interfaces
{
    public interface IGradeComputationService
    {
        double CalculateWeightedScore(double score, double weight);
        string ConvertToLetterGrade(double percentage);
    }
}