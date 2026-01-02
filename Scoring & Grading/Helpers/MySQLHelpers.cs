using MySql.Data.MySqlClient;
using Scoring___Grading.DBContext;
using Scoring___Grading.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoring___Grading.Helpers
{
    public class MySQLHelpers
    {
        private MySQLAdminContext _context = new MySQLAdminContext();

        public List<StudentExamReport> GetStudentExamReport(string subjectCode)
        {
            List<StudentExamReport> reports = new List<StudentExamReport>();

            using (MySqlConnection conn = _context.GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(
                    "GetStudentExamReportBySubjectCode", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_subject_code", subjectCode);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        reports.Add(new StudentExamReport
                        {
                            StudentId = reader.GetInt32("student_id"),
                            ExamName = reader.GetString("exam_name"),
                            SubjectCode = reader.GetString("subject_code"),
                            TotalCorrect = reader.GetInt32("total_correct")
                        });
                    }
                }
            }
            return reports;
        }
    }
}