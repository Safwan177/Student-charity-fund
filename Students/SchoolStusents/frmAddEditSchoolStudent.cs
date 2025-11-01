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
    public partial class frmAddEditSchoolStudent : Form
    {
        public frmAddEditSchoolStudent(int SchoolStudent)
        {
            InitializeComponent();
            _SchoolStudent = SchoolStudent;
            Mode = enMode.Update;
        }
        public frmAddEditSchoolStudent()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        private int _SchoolStudent = -1;

        private clsSchoolStudentBLL _Student;
        private void _LoadData()
        {
            _Student = clsSchoolStudentBLL.GetSchoolStudentInfoByID(_SchoolStudent);
            if (_Student == null)
            {
                MessageBox.Show("The Student ID " + _SchoolStudent.ToString() + "Is Note Found ", " Fail", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            txtAddress.Text = _Student.Address;
            txtBranch.Text = _Student.Branch;
            txtFirstName.Text = _Student.FirstName;
            txtLastName.Text = _Student.LastName;
            txtScondName.Text = _Student.SecondName;
            txtNationalNO.Text = _Student.NationalNO;
            txtNote.Text = _Student.Note;
            txtPhonNumber.Text = _Student.PhoneNumber;
            txtCkass.Text = _Student.Class;
            txtSchoolName.Text = _Student.SecondName;
            if (_Student.Gendor == false)
                RdbFemal.Checked = true;
            else
                rdbMail.Checked = true;

            // i will update it
            cmbCstegory.SelectedItem = cmbCstegory.FindString(_Student.Category.ToString());

            lblID.Text = _Student.SchoolStudentID.ToString();
        }
        private void AddEditSchoolStudent_Load(object sender, EventArgs e)
        {
            LoadCategories();
            if (Mode == enMode.AddNew)
            {
                _Student = new clsSchoolStudentBLL();
                this.Text = "Add School Student";
                lblTitle.Text = "Add Univerity Student";
            }
            else
            {
                this.Text = "Update School Student";
                lblTitle.Text = "Update Univerity Student";
                _LoadData();
            }
        }

        public void LoadCategories()
        {
         cmbCstegory.DataSource=clsCategoriesBLL.GetAllCategoryNames();
           
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some felde is requair", " Fail", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            _Student.Address = txtAddress.Text;
            _Student.Branch = txtBranch.Text;
            _Student.FirstName = txtFirstName.Text;
            _Student.LastName = txtLastName.Text;
            _Student.SecondName = txtScondName.Text;
            _Student.NationalNO = txtNationalNO.Text;
            _Student.Note = txtNote.Text;
            _Student.PhoneNumber = txtPhonNumber.Text;

           
            _Student.Class = txtCkass.Text;
            _Student.SecondName = txtScondName.Text;


            _Student.Gendor = rdbMail.Checked;


            if (cmbCstegory.SelectedValue != null)
                // +1 because combo box is zero based index
                _Student.Category = (clsCategoriesBLL.enCategory)cmbCstegory.SelectedIndex + 1;
            
            if (_Student.Save())
            {
                MessageBox.Show("Student Saved Seccsessfuly ", " Save", MessageBoxButtons.OKCancel, MessageBoxIcon.None);

                lblID.Text = _Student.SchoolStudentID.ToString();
                return;
            }
            else
            {
                MessageBox.Show("Srudent saved has fail ", " Fail", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
        }
        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            Control temp = sender as Control;
            if (string.IsNullOrEmpty(temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(temp, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(temp, null);
            }

        }
        private void txtNationalNO_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNationalNO.Text))
            {
                e.Cancel = true;
                txtNationalNO.Focus();
                errorProvider1.SetError(txtNationalNO, "NationalNO name shoud have a value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNationalNO, "");
            }
            if (txtNationalNO.Text != _Student.NationalNO && clsUniversityStudenBLL.IsNationalNoExist(txtNationalNO.Text))
            {
                txtNationalNO.Focus();
                errorProvider1.SetError(txtNationalNO, "NationalNO is used for another person");
                errorProvider1.SetError(txtNationalNO, "");

            }
            else
            {
                e.Cancel = false;

            }
        }

        private void txtSchoolName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
