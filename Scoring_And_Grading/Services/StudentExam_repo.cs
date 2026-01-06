using Scoring_And_Grading.Interfaces;
using Scoring_And_Grading.Models;
using System.Collections.Generic;

namespace Scoring_And_Grading.Services
{
    public class StudentExam_repo
    {
        private readonly IStudentExam _repo;

        public StudentExam_repo(IStudentExam repo)
        {
            _repo = repo;
        }

        public List<StudentExamReport> GetReportBySubject(string subjectCode)
        {
            return _repo.GetStudentExamReport(subjectCode);
        }
    }
}