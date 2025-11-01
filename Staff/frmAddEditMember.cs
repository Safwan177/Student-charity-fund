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
    public partial class frmAddEditMember : Form
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public frmAddEditMember()
        {
            InitializeComponent();
             Mode = enMode.AddNew;
        }
        public frmAddEditMember(int MemberID)
        {
            InitializeComponent();
            _MemberID = MemberID;
             Mode = enMode.Update;
        }
        private int _MemberID = -1;

        private clsStaffBLL Member=new clsStaffBLL();
        private void Form1_Load(object sender, EventArgs e)
        {
            if(Mode==enMode.AddNew)
            {
                dtpDatOfBirth.Value = DateTime.Now;
                dtpStartDato.Value = DateTime.Now;
                dtpEndDate.Enabled= false;
                this.Text = "Add New Member";
                lblTitle.Text = "Add New Member";    
            }
            else
            {
                this.Text = "Update Member";
                lblTitle.Text = "Update Member";
                _LoadData();
            }
        }

        private void _LoadData()
        {
            Member = clsStaffBLL.Find(_MemberID);
            if (Member != null)
            {

                txtFirstName.Text = Member.FirstName;
                txtLastName.Text = Member.LastName;
                txtSalary.Text = Member.Salary.ToString();
                txtScondName.Text = Member.SecondName;
                txtPhonNumber.Text = Member.PhoneNumber;
                txtJobTitele.Text = Member.JobTitel.ToString();
                dtpDatOfBirth.Value = Member.DateOfBirth;
                dtpStartDato.Value = Member.StartDate;
                dtpEndDate.Value = Member.EndDate;
                lblID.Text = Member.StaffID.ToString();
            }
            else
            {
                MessageBox.Show("The Member can not find", " Fail", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some felde is requair", " Fail", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            if (Mode == enMode.Update)
            {
                dtpEndDate.Enabled = true;
                Member.EndDate = dtpEndDate.Value;  
            }
               
                Member.Salary =Convert.ToDecimal( txtSalary.Text.ToString());
                Member.StartDate = DateTime.Now;
                Member.FirstName=txtFirstName.Text;
                Member.LastName=txtLastName.Text;
                Member.SecondName=txtScondName.Text;
                Member.DateOfBirth=dtpDatOfBirth.Value;
                Member.PhoneNumber=txtPhonNumber.Text;
                Member.Gendor = rdbMail.Checked;
                Member.JobTitel = txtJobTitele.Text;

                if(Member.Save())
                {
                    MessageBox.Show("Member Saved Seccsessfuly.", "Save", MessageBoxButtons.OK);
                    lblID.Text=Member.StaffID.ToString();
                    Mode = enMode.Update;
                }
                else
                {
                    MessageBox.Show("Member Saved Has Fail.", "Fail", MessageBoxButtons.OK,MessageBoxIcon.Error);

                }
            
        }

        private void btnCloce_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
