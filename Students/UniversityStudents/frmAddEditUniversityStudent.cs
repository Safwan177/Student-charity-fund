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
    public partial class frmAddEditUniversityStudent : Form
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public frmAddEditUniversityStudent(int UniversityStudentID)
        {
            InitializeComponent();
            _UniversityStudentID = UniversityStudentID;
            Mode = enMode.Update;
        }
        public frmAddEditUniversityStudent()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }
        private int _UniversityStudentID = -1;

        private clsUniversityStudenBLL _UniversityStuden = null;
        private void guna2HtmlLabel14_Click(object sender, EventArgs e)
        {

        }
        private void _LoadData()
        {
            _UniversityStuden = clsUniversityStudenBLL.GetUniversityStudentInfoByID(_UniversityStudentID);
            if (_UniversityStuden == null)
            {
                MessageBox.Show("The Student ID " + _UniversityStudentID.ToString() + "Is Note Found ", " Fail", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            txtAddress.Text = _UniversityStuden.Address;
            txtFaculty.Text = _UniversityStuden.Faculty;
            txtFirstName.Text = _UniversityStuden.FirstName;
            txtLastName.Text = _UniversityStuden.LastName;
            txtScondName.Text = _UniversityStuden.SecondName;
            txtNationalNO.Text = _UniversityStuden.NationalNO;
            txtNote.Text = _UniversityStuden.Note;
            txtPhonNumber.Text = _UniversityStuden.PhoneNumber;
            txtStudyYear.Text = _UniversityStuden.StudyYear.ToString();
            txtUniversityLocation.Text = _UniversityStuden.UniversityLocation;
            txtUniversityName.Text = _UniversityStuden.UnivarsityName;
            if (_UniversityStuden.Gendor == false)
                RdbFemal.Checked = true;
            else
                rdbMail.Checked = true;

            if(_UniversityStuden.IsArchieved== false)
                chkIsArchived.Checked = false;
            else
                chkIsArchived.Checked = true; 
            // i will update it
            cmbCstegory.SelectedItem = cmbCstegory.FindString(_UniversityStuden.Category.ToString());

            lblID.Text = _UniversityStuden.UniversityStudentID.ToString();
        }

        public void LoadCategories()
        {
            cmbCstegory.DataSource = clsCategoriesBLL.GetAllCategoryNames();

        }
        private void frmAddNewUniversityStudent_Load(object sender, EventArgs e)
        {
            LoadCategories();
            if (Mode == enMode.AddNew)
            {
                _UniversityStuden = new clsUniversityStudenBLL();
                this.Text = "Add School Student";
                lblTitle.Text = "Add School Student";
                pnArchived.Visible= false;
            }
            else
            {
                this.Text = "Update Univerity Student";
                lblTitle.Text = "Update Univerity Student";
                pnArchived.Visible = true;
                _LoadData();
            }
        }

        private void btnCloce_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some felde is requair", " Fail", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            _UniversityStuden.Address = txtAddress.Text;
            _UniversityStuden.Faculty = txtFaculty.Text;
            _UniversityStuden.FirstName = txtFirstName.Text;
            _UniversityStuden.LastName = txtLastName.Text;
            _UniversityStuden.SecondName = txtScondName.Text;
            _UniversityStuden.NationalNO = txtNationalNO.Text;
            _UniversityStuden.Note = txtNote.Text;
            _UniversityStuden.PhoneNumber = txtPhonNumber.Text;

            if (int.TryParse(txtStudyYear.Text, out int studyYear))
                _UniversityStuden.StudyYear = studyYear;
            else
                _UniversityStuden.StudyYear = 0; // أو عالج الخطأ حسب الحاجة

            _UniversityStuden.UniversityLocation = txtUniversityLocation.Text;
            _UniversityStuden.UnivarsityName = txtUniversityName.Text;


            _UniversityStuden.Gendor = rdbMail.Checked;

            _UniversityStuden.IsArchieved= chkIsArchived.Checked;
            if (cmbCstegory.SelectedValue != null)
                // +1 because combo box is zero based index
                _UniversityStuden.Category = (clsCategoriesBLL.enCategory) cmbCstegory.SelectedIndex+1;
            
            if (_UniversityStuden.Save())
            {
                MessageBox.Show("Student Saved Seccsessfuly ", " Save", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                
                lblID.Text= _UniversityStuden.UniversityStudentID.ToString();
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
            if (txtNationalNO.Text != _UniversityStuden.NationalNO && clsUniversityStudenBLL.IsNationalNoExist(txtNationalNO.Text))
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

        private void txtStudyYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void guna2CirclePictureBox15_Click(object sender, EventArgs e)
        {

        }
    }

}
