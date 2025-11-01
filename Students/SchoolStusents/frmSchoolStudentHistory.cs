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
    public partial class frmSchoolStudentHistory : Form
    {
        public frmSchoolStudentHistory(int SchoolStudentID)
        {
            InitializeComponent();
            _SchoolStudentID = SchoolStudentID;
        }
        private DataTable _dtAllPyments;
        private int _SchoolStudentID = -1;
        private void frmSchoolStudentHistory_Load(object sender, EventArgs e)
        {
            ucStudentWhithFiltter1.Mode = ucStudentWhithFiltter.enMode.School;

            ucStudentWhithFiltter1.LoadStudentData(_SchoolStudentID);

            _dtAllPyments = clsSchoolStudentPaymentBLL.GetAllSchoolStudentpaymentsForStudent(_SchoolStudentID);

            dgvStudentHistory.DataSource = _dtAllPyments;

            lblAllPaymentsValue.Text = _CalculatePaymentsValue().ToString();

            lblPaymentsCount.Text = dgvStudentHistory.Rows.Count.ToString();
        }
        private decimal _CalculatePaymentsValue()
        {

            decimal x = 0;
            for (int i = 0; i < dgvStudentHistory.RowCount; i++)
            {
                x += Convert.ToDecimal(dgvStudentHistory.Rows[i].Cells[3].Value);
            }
            return x;
        }

        private void dgvStudentHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }
    }
}
