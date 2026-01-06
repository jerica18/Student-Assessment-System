using Scoring_And_Grading.Models;
using Scoring_And_Grading.Interfaces;
using Scoring_And_Grading.DBContext;
using Scoring_And_Grading.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Scoring_And_Grading
{
    public partial class FormStudentExamReport : Form
    {
        #region Fields
        private readonly StudentExam_repo _examRepo;
        private const int TOTAL_QUESTIONS = 50;
        #endregion

        #region Constructor
        public FormStudentExamReport()
        {
            InitializeComponent();

            IStudentExam context = new MySQLStudentExamContext();
            _examRepo = new StudentExam_repo(context);

            InitializeGrid();
        }
        #endregion

        #region Grading Logic
        private double CalculatePercentage(int correct, int total)
        {
            if (total == 0) return 0;
            return ((double)correct / total) * 100;
        }

        private string GetLetterGrade(double percentage)
        {
            if (percentage >= 95) return "1.0 (Excellent)";
            if (percentage >= 90) return "1.5 (Very Good)";
            if (percentage >= 85) return "2.0 (Good)";
            if (percentage >= 80) return "2.5 (Satisfactory)";
            if (percentage >= 75) return "3.0 (Passing)";
            return "5.0 (Failed)";
        }
        #endregion

        #region Private Methods
        private void InitializeGrid()
        {
            dgvReport.Columns.Clear();
            dgvReport.ReadOnly = true;
            dgvReport.AllowUserToAddRows = false;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvReport.Columns.Add("StudentID", "Student ID");
            dgvReport.Columns.Add("ExamName", "Exam Name");
            dgvReport.Columns.Add("Subject", "Subject");
            dgvReport.Columns.Add("RawScore", "Score");
            dgvReport.Columns.Add("Percentage", "Percentage");
            dgvReport.Columns.Add("Grade", "Grade");
        }

        private void ComputeStatistics()
        {
            if (dgvReport.Rows.Count == 0) return;

            try
            {

                var percentages = dgvReport.Rows.Cast<DataGridViewRow>()
                    .Where(row => row.Cells[4].Value != null)
                    .Select(row => {
                        string val = row.Cells[4].Value.ToString().Replace("%", "");
                        return Convert.ToDouble(val);
                    })
                    .ToList();

                double highest = percentages.Max();
                double lowest = percentages.Min();
                double average = percentages.Average();

                lblStats.Text = $"Highest: {highest:0.00}%    Lowest: {lowest:0.00}%    Average: {average:0.00}%";
            }
            catch { 
            }
        }
        #endregion

        #region Event Handlers
        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            dgvReport.Rows.Clear();
            string subjectCode = txtSubjectCode.Text.Trim();

            if (string.IsNullOrEmpty(subjectCode))
            {
                MessageBox.Show("Please enter a Subject Code first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                List<StudentExamReport> reports = _examRepo.GetReportBySubject(subjectCode);

                foreach (var report in reports)
                {
                    double percentage = CalculatePercentage(report.TotalCorrect, TOTAL_QUESTIONS);
                    string grade = GetLetterGrade(percentage);

                    dgvReport.Rows.Add(
                        report.StudentId,
                        report.ExamName,
                        report.SubjectCode,
                        report.TotalCorrect,
                        percentage.ToString("0.00") + "%",
                        grade);
                }

                ComputeStatistics();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}