using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_Assessment_System.Data;
using Student_Assessment_System.Models;
using MySql.Data.MySqlClient;


namespace Student_Assessment_System.Services
{
    public class AssessmentService
    {
        private readonly Db _db;


        public AssessmentService(Db db)
        {
            _db = db;
        }


        public List<Exam> GetExamsByTeacher(int teacherId)
        {
            var list = new List<Exam>();
            try
            {
                _db.Open();
                string sql = "SELECT exam_id, subject_id, exam_title, time_limit, schedule FROM exams WHERE teacher_id=@t";
                using (var cmd = new MySqlCommand(sql, _db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@t", teacherId);
                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            list.Add(new Exam
                            {
                                Id = r.GetInt32("exam_id"),
                                SubjectId = (int)(r.IsDBNull(r.GetOrdinal("subjectId")) ? (int?)null : r.GetInt32("subjectId")),
                                Title = r.GetString("title"),
                                TimeLimit = (int)(r.IsDBNull(r.GetOrdinal("time_limit")) ? (int?)null : r.GetInt32("time_limit")),
                                Schedule = (DateTime)(r.IsDBNull(r.GetOrdinal("schedule")) ? (System.DateTime?)null : r.GetDateTime("schedule"))
                            });
                        }
                    }
                }
            }
            finally { _db.Close(); }


            return list;
        }
    }
}