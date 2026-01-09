namespace Score_And_Grade___Teacher_side__
{
    partial class FormTeacherDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpQuestionBox = new System.Windows.Forms.GroupBox();
            this.txtOptionD = new System.Windows.Forms.TextBox();
            this.txtOptionC = new System.Windows.Forms.TextBox();
            this.txtOptionB = new System.Windows.Forms.TextBox();
            this.txtOptionA = new System.Windows.Forms.TextBox();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.txtQuestionBox = new System.Windows.Forms.TextBox();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblQuestionCreator = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbSubjectType = new System.Windows.Forms.ComboBox();
            this.lblSubjectType = new System.Windows.Forms.Label();
            this.txtAssessmentName = new System.Windows.Forms.TextBox();
            this.lblAssessmentName = new System.Windows.Forms.Label();
            this.lblAssessmentType = new System.Windows.Forms.Label();
            this.cmbAssessmentType = new System.Windows.Forms.ComboBox();
            this.dgvQuestionsPreview = new System.Windows.Forms.DataGridView();
            this.btnRemoveSelection = new System.Windows.Forms.Button();
            this.numPassingScore = new System.Windows.Forms.NumericUpDown();
            this.lblPassingScore = new System.Windows.Forms.Label();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.grpQuestionBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestionsPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPassingScore)).BeginInit();
            this.SuspendLayout();
            // 
            // grpQuestionBox
            // 
            this.grpQuestionBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpQuestionBox.Controls.Add(this.txtOptionD);
            this.grpQuestionBox.Controls.Add(this.txtOptionC);
            this.grpQuestionBox.Controls.Add(this.txtOptionB);
            this.grpQuestionBox.Controls.Add(this.txtOptionA);
            this.grpQuestionBox.Controls.Add(this.btnAddQuestion);
            this.grpQuestionBox.Controls.Add(this.rbD);
            this.grpQuestionBox.Controls.Add(this.rbC);
            this.grpQuestionBox.Controls.Add(this.txtQuestionBox);
            this.grpQuestionBox.Controls.Add(this.rbB);
            this.grpQuestionBox.Controls.Add(this.rbA);
            this.grpQuestionBox.Controls.Add(this.label1);
            this.grpQuestionBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpQuestionBox.Location = new System.Drawing.Point(44, 175);
            this.grpQuestionBox.Name = "grpQuestionBox";
            this.grpQuestionBox.Size = new System.Drawing.Size(493, 293);
            this.grpQuestionBox.TabIndex = 0;
            this.grpQuestionBox.TabStop = false;
            this.grpQuestionBox.Enter += new System.EventHandler(this.grpQuestionBox_Enter);
            // 
            // txtOptionD
            // 
            this.txtOptionD.Location = new System.Drawing.Point(304, 194);
            this.txtOptionD.Name = "txtOptionD";
            this.txtOptionD.Size = new System.Drawing.Size(159, 22);
            this.txtOptionD.TabIndex = 11;
            // 
            // txtOptionC
            // 
            this.txtOptionC.Location = new System.Drawing.Point(304, 148);
            this.txtOptionC.Name = "txtOptionC";
            this.txtOptionC.Size = new System.Drawing.Size(159, 22);
            this.txtOptionC.TabIndex = 10;
            // 
            // txtOptionB
            // 
            this.txtOptionB.Location = new System.Drawing.Point(61, 197);
            this.txtOptionB.Name = "txtOptionB";
            this.txtOptionB.Size = new System.Drawing.Size(159, 22);
            this.txtOptionB.TabIndex = 9;
            // 
            // txtOptionA
            // 
            this.txtOptionA.Location = new System.Drawing.Point(61, 148);
            this.txtOptionA.Name = "txtOptionA";
            this.txtOptionA.Size = new System.Drawing.Size(159, 22);
            this.txtOptionA.TabIndex = 8;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddQuestion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddQuestion.Location = new System.Drawing.Point(120, 230);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(263, 42);
            this.btnAddQuestion.TabIndex = 7;
            this.btnAddQuestion.Text = "Add Question To List";
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Location = new System.Drawing.Point(281, 200);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(17, 16);
            this.rbD.TabIndex = 6;
            this.rbD.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(281, 151);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(17, 16);
            this.rbC.TabIndex = 5;
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // txtQuestionBox
            // 
            this.txtQuestionBox.Location = new System.Drawing.Point(19, 49);
            this.txtQuestionBox.Multiline = true;
            this.txtQuestionBox.Name = "txtQuestionBox";
            this.txtQuestionBox.Size = new System.Drawing.Size(456, 82);
            this.txtQuestionBox.TabIndex = 4;
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(38, 200);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(17, 16);
            this.rbB.TabIndex = 3;
            this.rbB.UseVisualStyleBackColor = true;
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(38, 151);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(17, 16);
            this.rbA.TabIndex = 2;
            this.rbA.TabStop = true;
            this.rbA.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblQuestionCreator);
            this.panel1.Location = new System.Drawing.Point(44, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 44);
            this.panel1.TabIndex = 1;
            // 
            // lblQuestionCreator
            // 
            this.lblQuestionCreator.AutoSize = true;
            this.lblQuestionCreator.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.lblQuestionCreator.Location = new System.Drawing.Point(3, 12);
            this.lblQuestionCreator.Name = "lblQuestionCreator";
            this.lblQuestionCreator.Size = new System.Drawing.Size(134, 19);
            this.lblQuestionCreator.TabIndex = 0;
            this.lblQuestionCreator.Text = "Question Creator";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(44, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(982, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "PUBLISH COMPLETE EXAM TO DATABASE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbSubjectType
            // 
            this.cmbSubjectType.Location = new System.Drawing.Point(44, 32);
            this.cmbSubjectType.Name = "cmbSubjectType";
            this.cmbSubjectType.Size = new System.Drawing.Size(197, 24);
            this.cmbSubjectType.TabIndex = 2;
            this.cmbSubjectType.SelectedIndexChanged += new System.EventHandler(this.cmbSubjectType_SelectedIndexChanged);
            // 
            // lblSubjectType
            // 
            this.lblSubjectType.AutoSize = true;
            this.lblSubjectType.Location = new System.Drawing.Point(41, 13);
            this.lblSubjectType.Name = "lblSubjectType";
            this.lblSubjectType.Size = new System.Drawing.Size(55, 16);
            this.lblSubjectType.TabIndex = 3;
            this.lblSubjectType.Text = "Subject:";
            // 
            // txtAssessmentName
            // 
            this.txtAssessmentName.Location = new System.Drawing.Point(44, 91);
            this.txtAssessmentName.Multiline = true;
            this.txtAssessmentName.Name = "txtAssessmentName";
            this.txtAssessmentName.Size = new System.Drawing.Size(197, 38);
            this.txtAssessmentName.TabIndex = 4;
            // 
            // lblAssessmentName
            // 
            this.lblAssessmentName.AutoSize = true;
            this.lblAssessmentName.Location = new System.Drawing.Point(41, 72);
            this.lblAssessmentName.Name = "lblAssessmentName";
            this.lblAssessmentName.Size = new System.Drawing.Size(124, 16);
            this.lblAssessmentName.TabIndex = 5;
            this.lblAssessmentName.Text = "Assessment Name:";
            // 
            // lblAssessmentType
            // 
            this.lblAssessmentType.AutoSize = true;
            this.lblAssessmentType.Location = new System.Drawing.Point(284, 13);
            this.lblAssessmentType.Name = "lblAssessmentType";
            this.lblAssessmentType.Size = new System.Drawing.Size(119, 16);
            this.lblAssessmentType.TabIndex = 6;
            this.lblAssessmentType.Text = "Assessment Type:";
            // 
            // cmbAssessmentType
            // 
            this.cmbAssessmentType.Location = new System.Drawing.Point(287, 32);
            this.cmbAssessmentType.Name = "cmbAssessmentType";
            this.cmbAssessmentType.Size = new System.Drawing.Size(220, 24);
            this.cmbAssessmentType.TabIndex = 7;
            // 
            // dgvQuestionsPreview
            // 
            this.dgvQuestionsPreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuestionsPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestionsPreview.Location = new System.Drawing.Point(567, 12);
            this.dgvQuestionsPreview.Name = "dgvQuestionsPreview";
            this.dgvQuestionsPreview.RowHeadersWidth = 51;
            this.dgvQuestionsPreview.RowTemplate.Height = 24;
            this.dgvQuestionsPreview.Size = new System.Drawing.Size(459, 394);
            this.dgvQuestionsPreview.TabIndex = 8;
            // 
            // btnRemoveSelection
            // 
            this.btnRemoveSelection.BackColor = System.Drawing.Color.Red;
            this.btnRemoveSelection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveSelection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemoveSelection.Location = new System.Drawing.Point(763, 426);
            this.btnRemoveSelection.Name = "btnRemoveSelection";
            this.btnRemoveSelection.Size = new System.Drawing.Size(263, 42);
            this.btnRemoveSelection.TabIndex = 9;
            this.btnRemoveSelection.Text = "Remove Selected Question";
            this.btnRemoveSelection.UseVisualStyleBackColor = false;
            this.btnRemoveSelection.Click += new System.EventHandler(this.btnRemoveSelection_Click);
            // 
            // numPassingScore
            // 
            this.numPassingScore.Location = new System.Drawing.Point(287, 78);
            this.numPassingScore.Name = "numPassingScore";
            this.numPassingScore.Size = new System.Drawing.Size(179, 22);
            this.numPassingScore.TabIndex = 11;
            // 
            // lblPassingScore
            // 
            this.lblPassingScore.AutoSize = true;
            this.lblPassingScore.Location = new System.Drawing.Point(284, 59);
            this.lblPassingScore.Name = "lblPassingScore";
            this.lblPassingScore.Size = new System.Drawing.Size(98, 16);
            this.lblPassingScore.TabIndex = 12;
            this.lblPassingScore.Text = "Passing Score:";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(287, 125);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(232, 22);
            this.dtpStartTime.TabIndex = 13;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(284, 106);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(71, 16);
            this.lblStartTime.TabIndex = 14;
            this.lblStartTime.Text = "Start Time:";
            // 
            // FormTeacherDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 561);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.lblPassingScore);
            this.Controls.Add(this.numPassingScore);
            this.Controls.Add(this.btnRemoveSelection);
            this.Controls.Add(this.dgvQuestionsPreview);
            this.Controls.Add(this.cmbAssessmentType);
            this.Controls.Add(this.lblAssessmentType);
            this.Controls.Add(this.lblAssessmentName);
            this.Controls.Add(this.txtAssessmentName);
            this.Controls.Add(this.lblSubjectType);
            this.Controls.Add(this.cmbSubjectType);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpQuestionBox);
            this.Name = "FormTeacherDashboard";
            this.Text = "FormTeacherDashboard";
            this.Load += new System.EventHandler(this.FormTeacherDashboard_Load);
            this.grpQuestionBox.ResumeLayout(false);
            this.grpQuestionBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestionsPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPassingScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpQuestionBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblQuestionCreator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.TextBox txtQuestionBox;
        private System.Windows.Forms.ComboBox cmbSubjectType;
        private System.Windows.Forms.Label lblSubjectType;
        private System.Windows.Forms.TextBox txtAssessmentName;
        private System.Windows.Forms.Label lblAssessmentName;
        private System.Windows.Forms.Label lblAssessmentType;
        private System.Windows.Forms.ComboBox cmbAssessmentType;
        private System.Windows.Forms.DataGridView dgvQuestionsPreview;
        private System.Windows.Forms.Button btnRemoveSelection;
        private System.Windows.Forms.TextBox txtOptionD;
        private System.Windows.Forms.TextBox txtOptionC;
        private System.Windows.Forms.TextBox txtOptionB;
        private System.Windows.Forms.TextBox txtOptionA;
        private System.Windows.Forms.NumericUpDown numPassingScore;
        private System.Windows.Forms.Label lblPassingScore;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label lblStartTime;
    }
}