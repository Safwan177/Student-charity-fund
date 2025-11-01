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

namespace student.Donations
{
    public partial class frmDonationList : Form
    {
        public frmDonationList()
        {
            InitializeComponent();
        }
        DataTable _dtDonantion = new DataTable();
        private void frmDonationList_Load(object sender, EventArgs e)
        {
            _dtDonantion = clsDonationsBLL.GeAlltDonation();
            dgvDonations.DataSource = _dtDonantion;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                dgvDonations.DataSource = clsDonationsBLL.GeAlltDonation();
                return;
            }
            string Fillter = "";

            switch (cmbFillter.SelectedItem)
            {
                case "Donor ID":
                    Fillter = "DonorID";
                    break;
                case "Donation ID":
                    Fillter = "DonationID";
                    break;
                case "Donor Name":
                    Fillter = "DonorName";
                    break;

            }


            if (Fillter == "DonorID"|| Fillter == "DonationID")
            {
                _dtDonantion.DefaultView.RowFilter = string.Format("[{0}] = {1}", Fillter, txtSearch.Text.Trim());
                dgvDonations.DataSource = _dtDonantion;
            }
            else
            {
                _dtDonantion.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", Fillter, txtSearch.Text.Trim());
                dgvDonations.DataSource = _dtDonantion;

            }
        }

        private void cmbFillter_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbFillter.SelectedItem == "None")
            {
                dgvDonations.DataSource = clsDonationsBLL.GeAlltDonation();
                txtSearch.Visible = false;
            }
            else
            {
                txtSearch.Visible = true;

            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFillter.SelectedItem == "Donor ID"|| cmbFillter.SelectedItem == "Donation ID")
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddDonation frm =new frmAddDonation();
            frm.ShowDialog();
            frmDonationList_Load(null, null);
        }

        private void btnCloce_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
