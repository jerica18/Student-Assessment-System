using Student_Assessment_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Assessment_System
{
    public partial class StudentForm : Form
    {
        private readonly User _student;

        public StudentForm()
        {
        }

        public StudentForm(User Student)
        {
            InitializeComponent();
            _student = Student;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
