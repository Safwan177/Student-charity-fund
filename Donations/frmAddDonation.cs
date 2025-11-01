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
    public partial class frmAddDonation : Form
    {
        public frmAddDonation()
        {
            InitializeComponent();
        }
        private clsDonationsBLL Donations= new clsDonationsBLL();
        private void btnSave_Click(object sender, EventArgs e)
        {
            Donations.Amount=Convert.ToDecimal(txtDonationAmount.Text);
            Donations.DonationDate=DateTime.Now;
            Donations.DonorID = ctrDonorSearch1.Donor.DonorID;
            if (Donations.Save())
            {
                MessageBox.Show("Donations Saved Seccsessfuly.", "Save", MessageBoxButtons.OK);
                lblID.Text = Donations.DonationID.ToString();
                
            }
            else
            {
                MessageBox.Show("Donations Saved Has Fail.", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btnCloce_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
