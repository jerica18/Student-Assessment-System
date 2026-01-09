using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Score_And_Grade___Teacher_side__.Interfaces
{
    public interface ITeacherRepository
    {
        DataTable GetAllSubjects();

        int CreateExam(string name, string type, int assignmentId, decimal passingScore, DateTime startTime);

        void AddQuestionWithOptions(int examId, string text, string difficulty, int points, List<string> options, int correctIndex);
    }
}