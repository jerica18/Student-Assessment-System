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
    public partial class TeacherForm : Form
    {
        private readonly User _teacher;

        public TeacherForm()
        {
        }

        public TeacherForm(User Teacher)
        {
            InitializeComponent();
            _teacher = Teacher;
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {

        }
    }
}
