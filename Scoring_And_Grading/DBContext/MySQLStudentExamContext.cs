using MySql.Data.MySqlClient;
using Scoring_And_Grading.Interfaces;
using Scoring_And_Grading.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Scoring_And_Grading.DBContext
{
    public class MySQLStudentExamContext : IStudentExam
    {
        private string _constr = Helpers.MySQLHelpers.GetConnectionString();

        public List<StudentExamReport> GetStudentExamReport(string subjectCode)
        {
            List<StudentExamReport> reportList = new List<StudentExamReport>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("GetStudentExamReportBySubjectCode", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_subject_code", subjectCode);
                        conn.Open();

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                reportList.Add(new StudentExamReport()
                                {
                                    StudentId = Convert.ToInt32(reader["student_id"]),
                                    ExamName = reader["exam_name"].ToString(),
                                    SubjectCode = reader["subject_code"].ToString(),
                                    TotalCorrect = Convert.ToInt32(reader["total_correct"])
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading report: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return reportList;
        }
    }
}