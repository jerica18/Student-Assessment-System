using System.Linq;
using System.Windows.Forms;

namespace Scoring_And_Grading
{
    partial class FormStudentExamReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtSubjectCode = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.lblStats = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 63);
            this.panel1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Location = new System.Drawing.Point(928, 14);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(84, 32);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "LOG OUT";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1035, 59);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "STUDENT EXAM SCORING AND GRADING";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.BackColor = System.Drawing.Color.Transparent;
            this.lblSubject.Font = new System.Drawing.Font("Californian FB", 11F, System.Drawing.FontStyle.Bold);
            this.lblSubject.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSubject.Location = new System.Drawing.Point(300, 115);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(112, 22);
            this.lblSubject.TabIndex = 1;
            this.lblSubject.Text = "Subject Code";
            // 
            // txtSubjectCode
            // 
            this.txtSubjectCode.Location = new System.Drawing.Point(420, 112);
            this.txtSubjectCode.Name = "txtSubjectCode";
            this.txtSubjectCode.Size = new System.Drawing.Size(180, 22);
            this.txtSubjectCode.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(610, 105);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(110, 35);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load Reports";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click_1);
            // 
            // dgvReport
            // 
            this.dgvReport.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(100, 180);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.Size = new System.Drawing.Size(839, 482);
            this.dgvReport.TabIndex = 4;
            // 
            // lblStats
            // 
            this.lblStats.BackColor = System.Drawing.Color.Transparent;
            this.lblStats.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStats.Font = new System.Drawing.Font("Californian FB", 11F, System.Drawing.FontStyle.Bold);
            this.lblStats.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStats.Location = new System.Drawing.Point(0, 635);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(1039, 152);
            this.lblStats.TabIndex = 5;
            this.lblStats.Text = "Highest:       Lowest:       Average:       ";
            this.lblStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.Location = new System.Drawing.Point(461, 735);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 40);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // FormStudentExamReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Scoring_And_Grading.Properties.Resources._6045432;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1039, 787);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtSubjectCode);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormStudentExamReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Exam Report";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtSubjectCode;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Button btnClose;
    }
}