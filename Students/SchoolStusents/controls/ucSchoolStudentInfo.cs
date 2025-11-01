using StudentCharityFundBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student.SchoolStusents
{
    public partial class ucSchoolStudentInfo : UserControl
    {
        public ucSchoolStudentInfo()
        {
            InitializeComponent();
        }
        private clsSchoolStudentBLL _student;

        public clsSchoolStudentBLL SchoolStudent { get { return _student; } }
        public void LoadStudenInfoByID(int SchoolStudentID)
        {
            _student = clsSchoolStudentBLL.GetSchoolStudentInfoByID(SchoolStudentID);
            if (_student == null)
            {
                MessageBox.Show("The student is not found!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ucBaseStudentInfo1.LoadInfo(_student.StudentID);
            lblBranch.Text = _student.Branch;
            lblID.Text = _student.SchoolStudentID.ToString();
            lblClass.Text = _student.Class;
            lblSchoolName.Text = _student.School;
        } 
        public void LoadStudenInfoByNationalNo(string NationalNo)
        {
            _student = clsSchoolStudentBLL.GetSchoolStudentInfoByNationalNO(NationalNo);
            if (_student == null)
            {
                MessageBox.Show("The student is not found!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ucBaseStudentInfo1.LoadInfo(_student.StudentID);
            lblBranch.Text = _student.Branch;
            lblID.Text = _student.SchoolStudentID.ToString();
            lblClass.Text = _student.Class;
            lblSchoolName.Text = _student.School;
        }
        private void ucSchoolStudentInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
