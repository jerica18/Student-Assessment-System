using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Score_And_Grade___Teacher_side__.Models;
using Score_And_Grade___Teacher_side__.Services;

namespace Score_And_Grade___Teacher_side__
{
    public partial class FormTeacherDashboard : Form
    {
        private readonly TeacherService _teacherService;
        private List<Question> _tempQuestions = new List<Question>();

        public FormTeacherDashboard(TeacherService teacherService)
        {
            InitializeComponent();
            _teacherService = teacherService;
        }

        private void FormTeacherDashboard_Load(object sender, EventArgs e)
        {
            dgvQuestionsPreview.AutoGenerateColumns = false;
            dgvQuestionsPreview.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Question Text",
                DataPropertyName = "QuestionText",
                Width = 200
            });

            cmbAssessmentType.Items.Clear();
            cmbAssessmentType.Items.AddRange(new string[] { "First Exam", "Second Exam", "Third Exam", "Final Exam", "Quiz" });
            cmbAssessmentType.SelectedIndex = 0;

            try
            {
                DataTable subjects = _teacherService.GetAllSubjects();
                cmbSubjectType.DataSource = subjects;
                cmbSubjectType.DisplayMember = "subject_name";
                cmbSubjectType.ValueMember = "subject_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load subjects: " + ex.Message);
            }
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuestionBox.Text))
            {
                MessageBox.Show("Please enter a question first!", "Input Missing");
                return;
            }

            var question = new Question
            {
                QuestionText = txtQuestionBox.Text,
                Difficulty = "Medium",
                Points = 1,
                Options = new List<Option>
                {
                    new Option { OptionText = txtOptionA.Text, IsCorrect = rbA.Checked },
                    new Option { OptionText = txtOptionB.Text, IsCorrect = rbB.Checked },
                    new Option { OptionText = txtOptionC.Text, IsCorrect = rbC.Checked },
                    new Option { OptionText = txtOptionD.Text, IsCorrect = rbD.Checked }
                }
            };

            _tempQuestions.Add(question);
            RefreshGrid();
            ClearQuestionInputs();
        }

        private void btnRemoveSelection_Click(object sender, EventArgs e)
        {
            if (dgvQuestionsPreview.SelectedRows.Count > 0)
            {
                int index = dgvQuestionsPreview.SelectedRows[0].Index;
                _tempQuestions.RemoveAt(index);
                RefreshGrid();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedAssignmentId = Convert.ToInt32(cmbSubjectType.SelectedValue);

            var newExam = new Exam
            {
                ExamName = txtAssessmentName.Text,
                ExamType = cmbAssessmentType.Text,
                AssignmentId = selectedAssignmentId,
                PassingScore = numPassingScore.Value,
                StartTime = dtpStartTime.Value,
                Questions = _tempQuestions
            };

            string result = _teacherService.ValidateAndSaveExam(newExam);

            if (result == "Success")
            {
                MessageBox.Show("Exam published successfully!", "Success");
                _tempQuestions.Clear();
                RefreshGrid();
                this.Close();
            }
            else
            {
                MessageBox.Show(result, "Validation Error");
            }
        }

        private void RefreshGrid()
        {
            dgvQuestionsPreview.DataSource = null;
            dgvQuestionsPreview.DataSource = _tempQuestions;
        }

        private void ClearQuestionInputs()
        {
            txtQuestionBox.Clear();
            txtOptionA.Clear();
            txtOptionB.Clear();
            txtOptionC.Clear();
            txtOptionD.Clear();
            rbA.Checked = true;
            txtQuestionBox.Focus();
        }

        private void grpQuestionBox_Enter(object sender, EventArgs e)
        {

        }

        private void cmbSubjectType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}