using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;
using Score_And_Grade___Teacher_side__.Interfaces;
using System;

namespace Score_And_Grade___Teacher_side__.DBContext
{
    public class MySQLTeacherContext : ITeacherRepository
    {
        private string _constr = Helpers.MySQLHelpers.GetConnectionString();

        public DataTable GetAllSubjects()
        {
            using (var conn = new MySqlConnection(_constr))
            {
                string query = "SELECT subject_id, subject_name FROM tbl_subject WHERE subject_status = 'Active'";
                DataTable dt = new DataTable();
                using (var adapter = new MySqlDataAdapter(query, conn))
                {
                    adapter.Fill(dt);
                }
                return dt;
            }
        }

        public int CreateExam(string name, string type, int subjectId, decimal passingScore, DateTime startTime)
        {
            using (var conn = new MySqlConnection(_constr))
            {
                conn.Open();

                string findAssignmentQuery = "SELECT assignment_id FROM tbl_assignment WHERE subject_id = @sid LIMIT 1";
                int actualAssignmentId = 0;

                using (var cmdFind = new MySqlCommand(findAssignmentQuery, conn))
                {
                    cmdFind.Parameters.AddWithValue("@sid", subjectId);
                    object result = cmdFind.ExecuteScalar();

                    if (result != null)
                    {
                        actualAssignmentId = Convert.ToInt32(result);
                    }
                    else
                    {
                        string autoAssignQuery = "INSERT INTO tbl_assignment (employee_id, term_id, subject_id, assignment_schedule) " +
                                                 "VALUES (2, 1, @sid, 'TBA'); SELECT LAST_INSERT_ID();";

                        using (var cmdAuto = new MySqlCommand(autoAssignQuery, conn))
                        {
                            cmdAuto.Parameters.AddWithValue("@sid", subjectId);
                            actualAssignmentId = Convert.ToInt32(cmdAuto.ExecuteScalar());
                        }
                    }
                }

                string query = "INSERT INTO tbl_exam (assignment_id, exam_name, exam_type, passing_score, starttime) " +
                               "VALUES (@aid, @name, @type, @score, @start); SELECT LAST_INSERT_ID();";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@aid", actualAssignmentId);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@score", passingScore);
                    cmd.Parameters.AddWithValue("@start", startTime);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public void AddQuestionWithOptions(int examId, string text, string difficulty, int points, List<string> options, int correctIndex)
        {
            using (var conn = new MySqlConnection(_constr))
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        string qQuery = "INSERT INTO tbl_examquestion (exam_id, exam_question, questiondifficulty) " +
                                        "VALUES (@eid, @txt, @diff); SELECT LAST_INSERT_ID();";

                        int questionId;
                        using (var qCmd = new MySqlCommand(qQuery, conn, trans))
                        {
                            qCmd.Parameters.AddWithValue("@eid", examId);
                            qCmd.Parameters.AddWithValue("@txt", text);
                            qCmd.Parameters.AddWithValue("@diff", difficulty);
                            questionId = Convert.ToInt32(qCmd.ExecuteScalar());
                        }

                        string oQuery = "INSERT INTO tbl_options (examquestion_id, exam_option, correct_answer) " +
                                        "VALUES (@qid, @otxt, @iscor);";

                        for (int i = 0; i < options.Count; i++)
                        {
                            using (var oCmd = new MySqlCommand(oQuery, conn, trans))
                            {
                                oCmd.Parameters.AddWithValue("@qid", questionId);
                                oCmd.Parameters.AddWithValue("@otxt", options[i]);
                                oCmd.Parameters.AddWithValue("@iscor", i == correctIndex ? 1 : 0);

                                oCmd.ExecuteNonQuery();
                            }
                        }
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw ex;
                    }
                }
            }
        }
    }
}