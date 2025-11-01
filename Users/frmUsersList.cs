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
using System.Data;
namespace student.Users
{
    public partial class frmUsersList : Form
    {
        public frmUsersList()
        {
            InitializeComponent();
        }
        private DataTable _dtUsers;
        private void cmbFillter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFillter.SelectedItem == "None")
            {
                dgvUsers.DataSource = clsUserBLL.GetAllUsers();
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
                dgvUsers.DataSource = clsUserBLL.GetAllUsers();
            }
            string Fillter = "";

            switch (cmbFillter.SelectedItem)
            {
                case "User ID":
                    Fillter = "UserID";
                    break;
                case "User Name":
                    Fillter = "User Name";
                    break;
                
            }


            if (Fillter == "MemberID")
            {
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", Fillter, txtSearch.Text.Trim());
                dgvUsers.DataSource = _dtUsers;
            }
            else
            {
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", Fillter, txtSearch.Text.Trim());
                dgvUsers.DataSource = _dtUsers;

            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFillter.SelectedItem == "User ID")
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
        }

        private void frmUsersList_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = clsUserBLL.GetAllUsers();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm =new frmAddEditUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmUsersList_Load(null,null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Delete This User ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                return;
            if (clsUserBLL.Delete((int)dgvUsers.CurrentRow.Cells[0].Value))
                MessageBox.Show("Deleted Sucssfully", " don", MessageBoxButtons.OK);
            else
                MessageBox.Show("Deleted is Fail", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            frmUsersList_Load(null, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser();
            frm.ShowDialog();
            frmUsersList_Load(null, null);
        }
    }
}
