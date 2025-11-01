using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentCharityFundBLL;
namespace student.Donors
{
    public partial class frmAddEditDonor : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public frmAddEditDonor()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }
        public frmAddEditDonor(int DonorID)
        {
            InitializeComponent();
            Mode = enMode.Update;
            _DonorID = DonorID;
        }
        private int _DonorID = -1;

        private clsDonorBLL _Donor = new clsDonorBLL();
        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            var Temp = sender as Guna.UI2.WinForms.Guna2TextBox;
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }

        private void frmAddEditDonor_Load(object sender, EventArgs e)
        {
            if (Mode == enMode.AddNew)
            {
                this.Text = "Add New Donor";
                lblTitle.Text = "Add New Donor";
            }
            else
            {
                this.Text = "Update Donor";
                lblTitle.Text = "Update Donor";
                _LoadData();
            }
        }
        private void _LoadData()
        {
            _Donor = clsDonorBLL.Find(_DonorID);

            if (_Donor != null)
            {

                txtFirstName.Text = _Donor.FirstName;
                txtLastName.Text = _Donor.LastName;

                txtScondName.Text = _Donor.SecondName;
                txtPhonNumber.Text = _Donor.PhoneNumber;

                lblID.Text = _Donor.DonorID.ToString();
            }
            else
            {
                MessageBox.Show("The Donor can not find", " Fail", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some felde is requair", " Fail", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            _Donor.FirstName = txtFirstName.Text.ToString();
            _Donor.LastName = txtLastName.Text.ToString();

            _Donor.SecondName = txtScondName.Text.ToString();
            _Donor.PhoneNumber = txtPhonNumber.Text.ToString();

            if (_Donor.Save())
            {
                MessageBox.Show("Member Saved Seccsessfuly.", "Save", MessageBoxButtons.OK);
                lblID.Text = _Donor.DonorID.ToString();
                Mode = enMode.Update;
            }
            else
            {
                MessageBox.Show("Member Saved Has Fail.", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCloce_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
