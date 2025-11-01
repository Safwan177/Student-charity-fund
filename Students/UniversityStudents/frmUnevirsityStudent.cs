using student.Students;
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

namespace student
{
    public partial class frmUnevirsityStudent : Form
    {
        public frmUnevirsityStudent()
        {
            InitializeComponent();
        }
        DataTable _dtAllStudent = clsUniversityStudenBLL.GetAllUniversityStudent();
        private void frmUnevirsityStudent_Load(object sender, EventArgs e)
        {

            dgvStudent.DataSource = _dtAllStudent;
            cmbArchived.SelectedIndex = 0;
            cmbFillter.SelectedIndex = 0;
            lblUniversityStudentsRecords.Text = dgvStudent.Rows.Count.ToString();

           
                         
            if (dgvStudent.Rows.Count > 0)
            {
                dgvStudent.Columns[0].HeaderText = "Student ID";
                dgvStudent.Columns[0].Width = 30;

                dgvStudent.Columns[1].HeaderText = "Full Name";
                dgvStudent.Columns[1].Width = 80;

                dgvStudent.Columns[2].HeaderText = "National No.";
                dgvStudent.Columns[2].Width = 30;

                dgvStudent.Columns[3].HeaderText = "University Name";
                dgvStudent.Columns[3].Width = 10;

              
                dgvStudent.Columns[4].HeaderText = "Gender";
                dgvStudent.Columns[4].Width =10;

               
                dgvStudent.Columns[5].HeaderText = "Category";
                dgvStudent.Columns[5].Width = 20;

              
                dgvStudent.Columns[6].HeaderText = "Is Archived";
                dgvStudent.Columns[6].Width = 30;
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string Fillter = "";
            string IsArchived = cmbArchived.SelectedItem.ToString();

            if (cmbFillter.SelectedItem == "None")
            {
                if (IsArchived == "All")
                {
                    _dtAllStudent.DefaultView.RowFilter = string.Format("IsArchived = 1 || IsArchived = 0");
                }
                else
                {
                    if (IsArchived == "Yes")
                        _dtAllStudent.DefaultView.RowFilter = string.Format(" IsArchived = 1");
                    else
                        _dtAllStudent.DefaultView.RowFilter = string.Format("IsArchived = 0");

                }
            }
            if (txtSearch.Text == "")
            {
                dgvStudent.DataSource = clsUniversityStudenBLL.GetAllUniversityStudent();
                return;
            }
            
           
            switch (cmbFillter.SelectedItem.ToString())
            {
                case "Student ID":
                    Fillter = "UniversityStudentID";
                    break;
                case "Full Name":
                    Fillter = "FullName";
                    break;
                case "NationalNO":
                    Fillter = "NationalNO";
                    break;
                case "University":
                    Fillter = "UniversityName";
                    break;
                case "Faculty":
                    Fillter = "Faculty";
                    break;
                case "Study Year":
                    Fillter = "StudyYear";
                    break;
                case "Category":
                    Fillter = "CatgoryName";
                    break;


            }

          

            if (Fillter == "UniversityStudentID" || Fillter == "StudyYear")
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
            }

            dgvStudent.DataSource = _dtAllStudent;
            lblUniversityStudentsRecords.Text = dgvStudent.Rows.Count.ToString();

        }

        private void cmbFillter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFillter.SelectedItem.ToString() == "None")
            {
                dgvStudent.DataSource = clsUniversityStudenBLL.GetAllUniversityStudent();
                txtSearch.Visible = false;
            }
            else
            {
                txtSearch.Visible = true;

            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFillter.SelectedItem.ToString() == "StudentID ID" || cmbFillter.SelectedItem.ToString() == "StudyYear")
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frmAddEditUniversityStudent frm = new frmAddEditUniversityStudent();
            frm.ShowDialog();
            frmUnevirsityStudent_Load(null, null);
        }

        private void btnCloce_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUniversityStudent frm = new frmAddEditUniversityStudent((int)dgvStudent.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmUnevirsityStudent_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUniversityStudenBLL student = clsUniversityStudenBLL.GetUniversityStudentInfoByID((int)dgvStudent.CurrentRow.Cells[0].Value);
            if (student != null)
            {

                if (MessageBox.Show("Are You Sure To Delete This Student ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    return;
                if (student.Delete())
                    MessageBox.Show("Deleted Sucssfully", " don", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Deleted is Fail", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            frmUnevirsityStudent_Load(null, null);
        }

        private void showStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUniversityStudentInfo frm = new frmShowUniversityStudentInfo((int)dgvStudent.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmUnevirsityStudent_Load(null, null);
        }

        private void showStudentHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUniversityStudentHistory frm = new frmUniversityStudentHistory((int)dgvStudent.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

        }

        private void archivedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArchivedStudent frm = new frmArchivedStudent((int)dgvStudent.CurrentRow.Cells[0].Value);
            frm.Mode = ucStudentWhithFiltter.enMode.University;
            frm.ShowDialog();
            frmUnevirsityStudent_Load(null, null);

        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            archivedToolStripMenuItem.Enabled = !clsUniversityStudenBLL.GetUniversityStudentInfoByID((int)dgvStudent.CurrentRow.Cells[0].Value).IsArchieved;
        }

        private void cmbArchived_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch_TextChanged(null, null);
        }
    }
}
