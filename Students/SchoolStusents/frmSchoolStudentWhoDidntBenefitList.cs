using student.SchoolStusents;
using student.Students.UniversityStudents;
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

namespace student.Students.SchoolStusents
{
    public partial class frmSchoolStudentWhoDidntBenefitList : Form
    {
        public frmSchoolStudentWhoDidntBenefitList()
        {
            InitializeComponent();
        }
        DataTable _dtAllStudent;
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            _dtAllStudent = clsSchoolStudentPaymentBLL.GetAllStudentWhoDidntBenefit(Convert.ToDateTime(dtpDate.Value));
            dgvStudent.DataSource = _dtAllStudent;
            lblStudentsRecords.Text = dgvStudent.RowCount.ToString();
        }

        private void showStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowSchoolStudentInfo frm = new frmShowSchoolStudentInfo((int)dgvStudent.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void showStudentHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmSchoolStudentHistory frm = new frmSchoolStudentHistory((int)dgvStudent.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

        }

        private void btnCloce_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSchoolStudentWhoDidntBenefitList_Load(object sender, EventArgs e)
        {

        }
    }
}
