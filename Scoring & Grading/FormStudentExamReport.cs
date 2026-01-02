using Scoring___Grading.Helpers;
using Scoring___Grading.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scoring___Grading
{
    public partial class FormStudentExamReport : Form
    {
        private readonly MySQLHelpers _dbHelper;
        private readonly ScoringHelper _scoringHelper;
        private readonly GradeComputationHelper _gradeHelper;

        private const int TOTAL_QUESTIONS = 50;

        public FormStudentExamReport()
        {
            InitializeComponent();

            _dbHelper = new MySQLHelpers();
            _scoringHelper = new ScoringHelper();
            _gradeHelper = new GradeComputationHelper();

            InitializeGrid();
        }

        private void InitializeGrid()
        {
            dgvReport.AutoGenerateColumns = false;
            dgvReport.Columns.Clear();

            dgvReport.Columns.Add("StudentId", "Student ID");
            dgvReport.Columns.Add("ExamName", "Exam Name");
            dgvReport.Columns.Add("SubjectCode", "Subject Code");
            dgvReport.Columns.Add("TotalCorrect", "Correct Answers");
            dgvReport.Columns.Add("Percentage", "Percentage");
            dgvReport.Columns.Add("LetterGrade", "Grade");

            dgvReport.ReadOnly = true;
            dgvReport.AllowUserToAddRows = false;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dgvReport.Rows.Clear();
            lblStats.Text = string.Empty;

            string subjectCode = txtSubjectCode.Text.Trim();

            try
            {
                List<StudentExamReport> reports =
                    _dbHelper.GetStudentExamReport(subjectCode);

                if (reports.Count == 0)
                {
                    MessageBox.Show(
                        "No records found.",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                foreach (var report in reports)
                {
                    double percentage =
                        _scoringHelper.CalculatePercentage(
                            report.TotalCorrect,
                            TOTAL_QUESTIONS);

                    string grade =
                        _scoringHelper.ApplyGradingScale(percentage);

                    dgvReport.Rows.Add(
                        report.StudentId,
                        report.ExamName,
                        report.SubjectCode,
                        report.TotalCorrect,
                        percentage.ToString("0.00"),
                        grade);
                }

                ComputeStatistics();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ComputeStatistics()
        {
            if (dgvReport.Rows.Count == 0) return;

            List<double> percentages = dgvReport.Rows
                .Cast<DataGridViewRow>()
                .Select(row => Convert.ToDouble(row.Cells["Percentage"].Value))
                .ToList();

            double highest = percentages.Max();
            double lowest = percentages.Min();
            double average = percentages.Average();

            lblStats.Text =
                $"Highest: {highest:0.00}   " +
                $"Lowest: {lowest:0.00}   " +
                $"Average: {average:0.00}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {

        }
    }
}