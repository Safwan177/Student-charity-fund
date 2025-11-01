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
    public partial class frmUniversityStudentHistory : Form
    {
        public frmUniversityStudentHistory(int UniversityStudentID)
        {
            InitializeComponent();
            _UniversityStudentID=UniversityStudentID;

        }
        private DataTable _dtAllPyments;
        private int _UniversityStudentID = -1;
        private void frmUniversityStudentHistory_Load(object sender, EventArgs e)
        {
            ucStudentWhithFiltter1.Mode = ucStudentWhithFiltter.enMode.University;
            ucStudentWhithFiltter1.LoadStudentData(_UniversityStudentID);
            _dtAllPyments = clsUniversityStudentPaymentBLL.GetAllUniversityStudentpaymentsForStudent(_UniversityStudentID);
            dgvStudentHistory.DataSource = _dtAllPyments;
            lblAllPaymentsValue.Text= _CalculatePaymentsValue().ToString();
            lblPaymentsCount.Text=dgvStudentHistory.Rows.Count.ToString();
        }
        private decimal _CalculatePaymentsValue()
        {
        
            decimal x = 0;
            for (int i=0;i<dgvStudentHistory.RowCount;i++)
            {
                x += Convert.ToDecimal(dgvStudentHistory.Rows[i].Cells[4].Value);
            }
            return x;
        }
        private void ucStudentWhithFiltter1_Load(object sender, EventArgs e)
        {

        }

        private void btnCloce_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
