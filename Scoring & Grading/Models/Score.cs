using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoring___Grading.Models
{
    public class Score
    {
        public int CorrectAnswers { get; set; }
        public int TotalQuestions { get; set; }
        public double RawScore { get; set; }
        public double Percentage { get; set; }
        public string LetterGrade { get; set; }
    }
}