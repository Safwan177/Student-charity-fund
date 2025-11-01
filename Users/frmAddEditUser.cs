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
namespace student.Users
{
    public partial class frmAddEditUser : Form
    {
        public frmAddEditUser()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
            _UserID = -1;
            lblTitle.Text = "Add New User";
            this.Text = "Add New User";
        }
        public frmAddEditUser(int UserID)
        {
            InitializeComponent();
            Mode = enMode.Update;
            _UserID = UserID;
            lblTitle.Text = "Update User";
            this.Text = "Update User";
        }
        private clsUserBLL _User = new clsUserBLL();

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        private int _UserID = -1;
        private int _GetPermission()
        {
            int Permission = 0;
            if (cbAddPayments.Checked)
                Permission += Convert.ToInt32(cbAddPayments.Tag);
            if (cbCategories.Checked)
                Permission += Convert.ToInt32(cbCategories.Tag);
            if (cbDonations.Checked)
                Permission += Convert.ToInt32(cbDonations.Tag);
            if (cbDonors.Checked)
                Permission += Convert.ToInt32(cbDonors.Tag);
            if (cbStaff.Checked)
                Permission += Convert.ToInt32(cbStaff.Tag);
            if (cbStudents.Checked)
                Permission += Convert.ToInt32(cbStudents.Tag);
            if (cbUsers.Checked)
                Permission += Convert.ToInt32(cbUsers.Tag);

            return Permission;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some felde is requair", " Fail", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            _User.Password = txtPassword.Text;
            _User.UserName = txtUserName.Text;
            _User.MemberID = Convert.ToInt32(txtMemberID.Text);
            _User.Permission = _GetPermission();

            if (_User.Save())
            {
                MessageBox.Show("User saved seccssefuly ", "save", MessageBoxButtons.OK, MessageBoxIcon.None);
                lblID.Text = _User.UserID.ToString();

            }
            else
            {
                MessageBox.Show("User saved is fail ", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void _SetPermission()
        {
            if ((_User.Permission & Convert.ToInt32(cbAddPayments.Tag)) == Convert.ToInt32(cbAddPayments.Tag))
            {
                cbAddPayments.Checked = true;
            }
            if ((_User.Permission & Convert.ToInt32(cbCategories.Tag)) == Convert.ToInt32(cbCategories.Tag))
            {
                cbCategories.Checked = true;
            }
            if ((_User.Permission & Convert.ToInt32(cbDonations.Tag)) == Convert.ToInt32(cbDonations.Tag))
            {
                cbDonations.Checked = true;
            }
            if ((_User.Permission & Convert.ToInt32(cbDonors.Tag)) == Convert.ToInt32(cbDonors.Tag))
            {
                cbDonors.Checked = true;
            }
            if ((_User.Permission & Convert.ToInt32(cbStaff.Tag)) == Convert.ToInt32(cbStaff.Tag))
            {
                cbStaff.Checked = true;
            }
            if ((_User.Permission & Convert.ToInt32(cbStudents.Tag)) == Convert.ToInt32(cbStudents.Tag))
            {
                cbStudents.Checked = true;
            }
            if ((_User.Permission & Convert.ToInt32(cbUsers.Tag)) == Convert.ToInt32(cbUsers.Tag))
            {
                cbUsers.Checked = true;
            }
        }
        private void _LoadData()
        {
            _User = clsUserBLL.GetUserByID(_UserID);

            if (_User == null)
            {
                MessageBox.Show("The User ID " + _UserID.ToString() + " Is Note Found ", " Fail", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            txtMemberID.Text = _User.MemberID.ToString();
            txtPassword.Text = _User.Password;
            txtUserName.Text = _User.UserName.ToString();
            lblID.Text = _UserID.ToString();

            _SetPermission();
        }
        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            if (Mode == enMode.Update)
            {
                _LoadData();
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

       
    }
}
