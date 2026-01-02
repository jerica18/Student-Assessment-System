using Scoring___Grading.Helpers;
using Scoring___Grading.Interfaces;
using Scoring___Grading.Models;
using Scoring___Grading.Services;
using System.Collections.Generic;
using System.Linq;

namespace Scoring_And_Grading.Service
{
    public class StudentScoringService
    {
        private readonly MySQLHelpers _dbHelper;
        private readonly IScoringService _scoringService;
        private readonly IGradeComputationService _gradeService;

        public StudentScoringService()
        {
            _dbHelper = new MySQLHelpers();
            _scoringService = new ScoringService();
            _gradeService = new GradeComputationService();
        }

        public List<Score> GenerateScores(string subjectCode, int totalQuestions)
        {
            var reports = _dbHelper.GetStudentExamReport(subjectCode);
            var scores = new List<Score>();

            foreach (var report in reports)
            {
                double raw = _scoringService.CalculateRawScore(report.TotalCorrect);
                double percentage = _scoringService.CalculatePercentage(raw, totalQuestions);
                string grade = _gradeService.ConvertToLetterGrade(percentage);

                scores.Add(new Score
                {
                    CorrectAnswers = report.TotalCorrect,
                    TotalQuestions = totalQuestions,
                    RawScore = raw,
                    Percentage = percentage,
                    LetterGrade = grade
                });
            }

            return scores;
        }

        public Grade GetStatistics(List<Score> scores)
        {
            return new Grade
            {
                Highest = scores.Max(s => s.Percentage),
                Lowest = scores.Min(s => s.Percentage),
                Average = scores.Average(s => s.Percentage)
            };
        }
    }
}