using Score_And_Grade___Teacher_side__.Interfaces;
using Score_And_Grade___Teacher_side__.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Score_And_Grade___Teacher_side__.Services
{
    public class TeacherService
    {
        private readonly ITeacherRepository _repo;

        public TeacherService(ITeacherRepository repo)
        {
            _repo = repo;
        }

        public DataTable GetAllSubjects()
        {
            return _repo.GetAllSubjects();
        }

        public string ValidateAndSaveExam(Exam exam)
        {
            if (string.IsNullOrEmpty(exam.ExamName))
                return "Exam name is required!";

            if (exam.Questions.Count == 0)
                return "An exam must have at least one question!";

            int newExamId = _repo.CreateExam(exam.ExamName, exam.ExamType, exam.AssignmentId, exam.PassingScore, exam.StartTime);

            foreach (var q in exam.Questions)
            {
                _repo.AddQuestionWithOptions(newExamId, q.QuestionText, q.Difficulty, q.Points,
                    q.Options.Select(o => o.OptionText).ToList(),
                    q.Options.FindIndex(o => o.IsCorrect));
            }

            return "Success";
        }
    }
}