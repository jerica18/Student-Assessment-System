using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Assessment_System.Data;
using Student_Assessment_System.Services;

namespace Student_Assessment_System
{
    public partial class LoginForm : Form
    {
        private readonly UserService _userService;
        public LoginForm()
        {
            InitializeComponent();
            var conn = ConfigurationManager.ConnectionStrings
                ["DefaultConnection"].ConnectionString;
            var db = new Db(conn);
            _userService = new UserService(db);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
            var user = _userService.Authenticate(txtUsername.Text.Trim(), txtPassword.Text);
            if (user == null) 
            {
                lblError.Text = "Invalid Username or Password. Please Try Again!";
                return;
            }
            if (user.Role == "Admin") 
            {
                new AdminForm().Show();
            }
            if (user.Role == "Teacher") 
            {
                new TeacherForm().Show();
            }
            if (user.Role == "Student") 
            {
                new StudentForm().Show();
            }
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void llblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.FormClosed += (s, args) => this.Show();
            registerForm.Show();
            this.Hide();
        }
    }
}
