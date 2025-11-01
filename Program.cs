using student.Categories;
using student.Donations;
using student.Donors;
using student.Login;
using student.ScoolStusents;
using student.Students;
using student.Students.SchoolStusents;
using student.Students.UniversityStudents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student
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
            Application.Run(new frmLoginScreen());
        }
    }
}
