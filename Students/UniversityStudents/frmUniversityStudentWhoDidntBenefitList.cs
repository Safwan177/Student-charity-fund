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
namespace student.Students.UniversityStudents
{
    public partial class frmUniversityStudentWhoDidntBenefitList : Form
    {
        public frmUniversityStudentWhoDidntBenefitList()
        {
            InitializeComponent();
        }
        DataTable _dtAllStudent;
        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            _dtAllStudent = clsUniversityStudentPaymentBLL.GetAllStudentWhoDidntBenefit(Convert.ToDateTime(dtpDate.Value));
            dgvStudent.DataSource = _dtAllStudent;
            lblStudentsRecords.Text = dgvStudent.RowCount.ToString();
        }

        private void frmUniversityStudentWhoDidntBenefitList_Load(object sender, EventArgs e)
        {
            dtpDate.MaxDate = DateTime.Now;
        }

        private void btnCloce_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUniversityStudentInfo frm = new frmShowUniversityStudentInfo((int)dgvStudent.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void showStudentHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmUniversityStudentHistory frm = new frmUniversityStudentHistory((int)dgvStudent.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

        }
    }
}
