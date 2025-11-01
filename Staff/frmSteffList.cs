using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using StudentCharityFundBLL;
namespace student
{
    public partial class frmSteffList : Form
    {
        public frmSteffList()
        {
            InitializeComponent();
        }
        DataTable _dtMembers = clsStaffBLL.GetAllStaffMember();
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmSteffList_Load(object sender, EventArgs e)
        {
            dgvMembers.DataSource = clsStaffBLL.GetAllStaffMember();
          
            
        }

        private void btnCloce_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           if( cmbFillter.SelectedItem == "None")
            {
                dgvMembers.DataSource = clsStaffBLL.GetAllStaffMember();
                txtSearch.Visible = false;
            }
           else
            {
                txtSearch.Visible = true;

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                dgvMembers.DataSource = clsStaffBLL.GetAllStaffMember();
                return;
            }
            string Fillter = "";

            switch (cmbFillter.SelectedItem)
            {
                case "Member ID":
                    Fillter = "MemberID";
                    break;
                case "Name":
                    Fillter = "FullName";
                    break;
                case "Jobe Title":
                    break;
            }


            if (Fillter == "MemberID")
            {
                _dtMembers.DefaultView.RowFilter = string.Format("[{0}] = {1}", Fillter, txtSearch.Text.Trim());
                dgvMembers.DataSource = _dtMembers;
            }
            else
            {
                _dtMembers.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", Fillter, txtSearch.Text.Trim());
                dgvMembers.DataSource = _dtMembers;

            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFillter.SelectedItem == "Member ID")
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            frmAddEditMember frm = new frmAddEditMember();
            frm.ShowDialog();
            frmSteffList_Load(null, null);


        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure To Delete This Member ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                return;
            if (clsStaffBLL.DeleteStaffMember((int)dgvMembers.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Deleted Sucssfully", " don", MessageBoxButtons.OK);
                frmSteffList_Load(null,null);
            }
            else
                MessageBox.Show("Deleted is Fail", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditMember frm =new frmAddEditMember((int)dgvMembers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmSteffList_Load(null, null);


        }
    }
}
