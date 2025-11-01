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
    public partial class frmAddPayment : Form
    {
        public frmAddPayment()
        {
            InitializeComponent();
        }

        public enum enMode { School = 1, University = 2 };
        public enMode Mode { set; get; }

        private int _StudentID = -1;

        private void ucStudentWhithFiltter1_OnStudentSelected(int obj)
        {
            btnSave.Enabled = true;
            _StudentID = obj;

            if (ucStudentWhithFiltter1.UniversituStudent != null)
            {
                if (ucStudentWhithFiltter1.UniversituStudent.IsArchieved)
                {
                    MessageBox.Show("This Student Is Archived ,so you can not add pyment ", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSave.Enabled = false;
                    return;
                }

                Mode = enMode.University;

                _HasUniversityStudentPaymentInThisMonth();

                lblPaymentAmount.Text = ucStudentWhithFiltter1.UniversituStudent.CategoryInfo.Amount.ToString();
            }

            if (ucStudentWhithFiltter1.SchoolStudent != null)
            {
                if (ucStudentWhithFiltter1.SchoolStudent.IsArchieved)
                {
                    MessageBox.Show("This Student Is Archived ,so you can not add pyment ", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSave.Enabled = false;
                    return;
                }
                Mode = enMode.School;

                _HasSchoolStudentPaymentInThisMonth();

                lblPaymentAmount.Text = ucStudentWhithFiltter1.SchoolStudent.CategoryInfo.Amount.ToString();
               
            }
        }

        private void _HasUniversityStudentPaymentInThisMonth()
        {
            if(clsUniversityStudentPaymentBLL.HasPaymentInThisMonth(_StudentID))
            {
                MessageBox.Show("This student received the money in this month.", "Fail", MessageBoxButtons.OK);
                btnSave.Enabled = false;
                return;

            }
        }
        private void _HasSchoolStudentPaymentInThisMonth()
        {
            if(clsSchoolStudentPaymentBLL.HasPaymentInThisMonth(_StudentID))
            {
                MessageBox.Show("This student received the money in this month.", "Fail", MessageBoxButtons.OK);
                btnSave.Enabled = false;
                return;

            }
        }

        private void frmAddPayment_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
        }

        private void ucStudentWhithFiltter1_Load(object sender, EventArgs e)
        {

        }

        private void btnCloce_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Mode == enMode.School)
            {
                clsSchoolStudentPaymentBLL pyment = new clsSchoolStudentPaymentBLL();
                pyment.StudentID = _StudentID;
                pyment.Date = DateTime.Now;
                pyment.Amount =Convert.ToDecimal( lblPaymentAmount.Text);
                if (pyment.Save())
                {
                    MessageBox.Show("Pyment Added Seccsussfully", "", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    MessageBox.Show("Pyment Add is Fail", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                clsUniversityStudentPaymentBLL pyment = new clsUniversityStudentPaymentBLL();
                pyment.StudentID = _StudentID;
                pyment.Date = DateTime.Now;
                pyment.Amount = Convert.ToDecimal(lblPaymentAmount.Text);

                if (pyment.Save())
                {
                    MessageBox.Show("Pyment Added Seccsussfully", "", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    MessageBox.Show("Pyment Add is Fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
