using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentCharityFundBLL;
namespace student
{
    public partial class ucUniversityStudentInfo : UserControl
    {
        public ucUniversityStudentInfo()
        {
            InitializeComponent();
        }
        private clsUniversityStudenBLL _student;

        public clsUniversityStudenBLL UniversityStudent { get { return _student; } }
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
        public void LoadStudenInfo(int UniversityStudentInfo)
        {
             _student=clsUniversityStudenBLL.GetUniversityStudentInfoByID(UniversityStudentInfo);
            if(_student == null)
            {
                MessageBox.Show("The student is not found!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ucBaseStudentInfo1.LoadInfo(_student.StudentID);
            lblFaculty.Text = _student.Faculty;
            lblID.Text = _student.UniversityStudentID.ToString();
            lblStudyYear.Text = _student.StudyYear.ToString();
            lblUniversityLocatoin.Text = _student.UniversityLocation;
            lblUniversityName.Text = _student.UnivarsityName;
        }
        public void LoadStudenInfo(string NationalNo)
        {
             _student=clsUniversityStudenBLL.GetUniversityStudentInfoByNationalNO(NationalNo);
            if(_student == null)
            {
                MessageBox.Show("The student is not found!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ucBaseStudentInfo1.LoadInfo(_student.StudentID);
            lblFaculty.Text = _student.Faculty;
            lblID.Text = _student.UniversityStudentID.ToString();
            lblStudyYear.Text = _student.StudyYear.ToString();
            lblUniversityLocatoin.Text = _student.UniversityLocation;
            lblUniversityName.Text = _student.UnivarsityName;
        }
        private void ucUniversityStudentInfo_Load(object sender, EventArgs e)
        {

        }

        private void ucBaseStudentInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
