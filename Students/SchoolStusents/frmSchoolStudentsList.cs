using student.SchoolStusents;
using student.Students;
using student.Students.SchoolStusents;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace student.ScoolStusents
{
    public partial class frmSchollStudentsList : Form
    {
        public frmSchollStudentsList()
        {
            InitializeComponent();
        }
        DataTable _dtAllStudent; 

        private void frmScollStudentsList_Load(object sender, EventArgs e)
        {
            _dtAllStudent = clsSchoolStudentBLL.GetAllSchoolStudent();
            dgvStudent.DataSource = _dtAllStudent;

            cmbFillter.SelectedIndex = 0;
            lblStudentsRecords.Text = dgvStudent.Rows.Count.ToString();

            if (dgvStudent.Rows.Count > 0)
            {
                dgvStudent.Columns[0].HeaderText = "Student ID";
                dgvStudent.Columns[0].Width = 80;

                dgvStudent.Columns[1].HeaderText = "Full Name";
                dgvStudent.Columns[1].Width = 100;

                dgvStudent.Columns[2].HeaderText = "National No.";
                dgvStudent.Columns[2].Width = 80;

                dgvStudent.Columns[3].HeaderText = "School Name";
                dgvStudent.Columns[3].Width = 110;

                dgvStudent.Columns[4].HeaderText = "Class";
                dgvStudent.Columns[4].Width = 80;

                dgvStudent.Columns[5].HeaderText = "Branch";
                dgvStudent.Columns[5].Width = 80;

                dgvStudent.Columns[6].HeaderText = "CatgoryName";
                dgvStudent.Columns[6].Width = 90;

                dgvStudent.Columns[7].HeaderText = "Phone Number";
                dgvStudent.Columns[7].Width = 90;

                dgvStudent.Columns[8].HeaderText = "Gender";
                dgvStudent.Columns[8].Width = 100;

                dgvStudent.Columns[9].HeaderText = "Address";
                dgvStudent.Columns[9].Width = 60;

                dgvStudent.Columns[10].HeaderText = "Note";
                dgvStudent.Columns[10].Width = 60;

                dgvStudent.Columns[11].HeaderText = "Is Archived";
                dgvStudent.Columns[11].Width = 30;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                dgvStudent.DataSource = clsSchoolStudentBLL.GetAllSchoolStudent();
                return;
            }
            string Fillter = "";

            switch (cmbFillter.SelectedItem)
            {
                case "Student ID":
                    Fillter = "SchoolStudentID";
                    break;
                case "Full Name":
                    Fillter = "FullName";
                    break;
                case "NationalNO":
                    Fillter = "NationalNO";
                    break;
                case "School":
                    Fillter = "School";
                    break;
                case "Class":
                    Fillter = "Class";
                    break;
                case "Branch":
                    Fillter = "Branch";
                    break;
                case "Category":
                    Fillter = "CatgoryName";
                    break;
                        
            }

            string IsArchived = cmbArchived.SelectedItem.ToString();

            if (Fillter == "SchoolStudentID")
            {

                if (IsArchived == "All")
                {
                    _dtAllStudent.DefaultView.RowFilter = string.Format("[{0}] = {1}", Fillter, txtSearch.Text.Trim());
                }
                else
                {
                    if (IsArchived == "Yes")
                        _dtAllStudent.DefaultView.RowFilter = string.Format("[{0}] = {1} AND IsArchived = 1", Fillter, txtSearch.Text.Trim());
                    else
                        _dtAllStudent.DefaultView.RowFilter = string.Format("[{0}] = {1} AND IsArchived = 0", Fillter, txtSearch.Text.Trim());

                }
               
            }
            else
            {

                if (IsArchived == "All")
                {
                    _dtAllStudent.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", Fillter, txtSearch.Text.Trim().Replace("'", "''"));
                }
                else
                {
                    if (IsArchived == "Yes")
                        _dtAllStudent.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%' AND IsArchived = 1", Fillter, txtSearch.Text.Trim().Replace("'", "''"));
                    else
                        _dtAllStudent.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%' AND IsArchived = 0", Fillter, txtSearch.Text.Trim().Replace("'", "''"));

                }
                dgvStudent.DataSource = _dtAllStudent;

            }
            dgvStudent.DataSource = _dtAllStudent;

            lblStudentsRecords.Text = dgvStudent.Rows.Count.ToString();

        }

        private void cmbFillter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFillter.SelectedItem == "None")
            {
                dgvStudent.DataSource = clsSchoolStudentBLL.GetAllSchoolStudent();
                txtSearch.Visible = false;
            }
            else
            {
                txtSearch.Visible = true;

            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFillter.SelectedItem == "Student ID")
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
        }

        private void btnCloce_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            frmAddEditSchoolStudent frm = new frmAddEditSchoolStudent();
            frm.ShowDialog();
            frmScollStudentsList_Load(null,null);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditSchoolStudent frm = new frmAddEditSchoolStudent((int)dgvStudent.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmScollStudentsList_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsSchoolStudentBLL student = clsSchoolStudentBLL.GetSchoolStudentInfoByID((int)dgvStudent.CurrentRow.Cells[0].Value);
            if (student != null)
            {

                if (MessageBox.Show("Are You Sure To Delete This Student ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    return;
                if (student.Delete())
                    MessageBox.Show("Deleted Sucssfully", " don", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Deleted is Fail", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            frmScollStudentsList_Load(null, null);

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

        private void archivedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArchivedStudent frm = new frmArchivedStudent((int)dgvStudent.CurrentRow.Cells[0].Value);
            frm.Mode = ucStudentWhithFiltter.enMode.School;
            frm.ShowDialog();
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            archivedToolStripMenuItem.Enabled = !clsSchoolStudentBLL.GetSchoolStudentInfoByID((int)dgvStudent.CurrentRow.Cells[0].Value).IsArchieved;

        }

        private void cmbArchived_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch_TextChanged(null, null);
        }
    }
}
