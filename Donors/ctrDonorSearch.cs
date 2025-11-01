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
namespace student.Donors
{
    public partial class ctrDonorSearch : UserControl
    {
        public ctrDonorSearch()
        {
            InitializeComponent();
        }
        public clsDonorBLL Donor = new clsDonorBLL();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbFillter.SelectedItem == "Donor ID")
                Donor = clsDonorBLL.Find(Convert.ToInt32(txtSearch.Text));
            if (cmbFillter.SelectedItem == "Name")
                Donor = clsDonorBLL.Find(txtSearch.Text.ToString());

            if (Donor != null)
            {
                lblFirstName.Text = Donor.FirstName;
                lblLastName.Text = Donor.LastName;
                lblPhonNumber.Text = Donor.PhoneNumber;
                lblSecondName.Text = Donor.SecondName;
                lblID.Text = Donor.DonorID.ToString();

            }
            else
            {
                MessageBox.Show("can not find the donor! ", "fail", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void cmbFillter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFillter.SelectedItem == "None")
            {
                txtSearch.Visible = false;
            }
            else
            {
                txtSearch.Visible = true;

            }
        }
    }
}
