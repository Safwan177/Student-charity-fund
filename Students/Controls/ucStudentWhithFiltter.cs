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
    public partial class ucStudentWhithFiltter : UserControl
    {
        public ucStudentWhithFiltter()
        {
            InitializeComponent();
        }

        public event Action<int> OnStudentSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void StudentSelected(int StudentID)
        {
            Action<int> handler = OnStudentSelected;
            if (handler != null)
            {
                handler(StudentID); // Raise the event with the parameter
            }
        }

        public enum enMode { School = 1, University = 2 };
        private enMode _Mode = enMode.School;
        public enMode Mode { set {
                                   _Mode=value ; 
                                   switch(_Mode)
                                   {
                                       case enMode.School:
                                           {
                                               rdbSchool.Checked = true;
                                               ucSchoolStudentInfo1.Visible = true;
                                               ucUniversityStudentInfo1.Visible = false;
                                               break;
                                           }
                                       case enMode.University:
                                           {
                                               rdbUniversity.Checked = true;
                                               ucSchoolStudentInfo1.Visible = false;
                                               ucUniversityStudentInfo1.Visible = true;
                                               break;
                                           }
                                   } } get {return _Mode; } }

        public clsUniversityStudenBLL UniversituStudent { get { return ucUniversityStudentInfo1.UniversityStudent; } }
        public clsSchoolStudentBLL SchoolStudent { get {return ucSchoolStudentInfo1.SchoolStudent; } }



        private void ucStudentWhithFiltter_Load(object sender, EventArgs e)
        {
            cmbFillter.SelectedIndex= 0;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void LoadStudentData(int StudentID)
        {
            cmbFillter.SelectedIndex = 1;

           txtSearch.Text=StudentID.ToString();
            btnSearch.PerformClick();
          pnFillter.Enabled = false;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") 
                MessageBox.Show("there is no value to search","Fail",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if(_Mode== enMode.School)
            {
                if (cmbFillter.Text == "Student ID")
                    ucSchoolStudentInfo1.LoadStudenInfoByID(Convert.ToInt32(txtSearch.Text));
                else
                    ucSchoolStudentInfo1.LoadStudenInfoByNationalNo(txtSearch.Text);


                //if the event call from any where 
                if (OnStudentSelected != null)
                    OnStudentSelected(ucSchoolStudentInfo1.SchoolStudent.SchoolStudentID);

            }
            else
            {
                if (cmbFillter.Text == "Student ID")
                    ucUniversityStudentInfo1.LoadStudenInfo(Convert.ToInt32(txtSearch.Text));
                else
                    ucUniversityStudentInfo1.LoadStudenInfo(txtSearch.Text);
                //if the event call from any where 
                if (OnStudentSelected != null)
                    OnStudentSelected(ucUniversityStudentInfo1.UniversityStudent.UniversityStudentID);

            }

        }

        private void RdbFemal_CheckedChanged(object sender, EventArgs e)
        {
            _Mode= enMode.School;
            ucSchoolStudentInfo1.Visible = true;
            ucUniversityStudentInfo1.Visible = false;
        }

        private void rdbMail_CheckedChanged(object sender, EventArgs e)
        {
            _Mode = enMode.University;
            ucSchoolStudentInfo1.Visible = false;
            ucUniversityStudentInfo1.Visible = true;
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cmbFillter.SelectedIndex == 1) //studet id
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbFillter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFillter.Text == "None")
            {
                txtSearch.Visible = false;
                btnSearch.Enabled = false;
            }
            else
            {
                txtSearch.Visible = true;
                btnSearch.Enabled = true;
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucUniversityStudentInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
