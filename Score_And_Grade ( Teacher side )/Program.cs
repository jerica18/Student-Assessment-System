using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Score_And_Grade___Teacher_side__.DBContext;
using Score_And_Grade___Teacher_side__.Services;

namespace Score_And_Grade___Teacher_side__
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var repo = new MySQLTeacherContext();
            var service = new TeacherService(repo);
            Application.Run(new FormTeacherDashboard(service));
        }
    }
}