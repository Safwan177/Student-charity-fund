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

namespace student.Donors
{
    public partial class frmDonorList : Form
    {
        public frmDonorList()
        {
            InitializeComponent();
        }

        private void btnCloce_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataTable _dtDonors = new DataTable();
        private void frmDonorList_Load(object sender, EventArgs e)
        {
            _dtDonors = clsDonorBLL.GetAllDonors();
            dgvDonors.DataSource = _dtDonors;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditDonor frm =new frmAddEditDonor();
            frm.ShowDialog();
            frmDonorList_Load(null,null);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                dgvDonors.DataSource = clsDonorBLL.GetAllDonors();
                return;
            }
            string Fillter = "";

            switch (cmbFillter.SelectedItem)
            {
                case "Donor ID":
                    Fillter = "DonorID";
                    break;
                case "Name":
                    Fillter = "FullName";
                    break;
                
            }


            if (Fillter == "DonorID")
            {
                _dtDonors.DefaultView.RowFilter = string.Format("[{0}] = {1}", Fillter, txtSearch.Text.Trim());
                dgvDonors.DataSource = _dtDonors;
            }
            else
            {
                _dtDonors.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", Fillter, txtSearch.Text.Trim());
                dgvDonors.DataSource = _dtDonors;

            }
        }

        private void cmbFillter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFillter.SelectedItem == "None")
            {
                dgvDonors.DataSource = clsDonorBLL.GetAllDonors();
                txtSearch.Visible = false;
            }
            else
            {
                txtSearch.Visible = true;

            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFillter.SelectedItem == "Donor ID")
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Delete This Donor ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                return;
            if (clsDonorBLL.Delete((int)dgvDonors.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Deleted Sucssfully", " don", MessageBoxButtons.OK);
                frmDonorList_Load(null, null);

            }
            else
                MessageBox.Show("Deleted is Fail", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditDonor frm =new frmAddEditDonor((int)dgvDonors.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmDonorList_Load(null, null);

        }

        private void dgvDonors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }
    }
}
