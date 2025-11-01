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
namespace student.Categories
{
    public partial class frmCategoriesList : Form
    {
        public frmCategoriesList()
        {
            InitializeComponent();
        }

        private void frmCategoriesList_Load(object sender, EventArgs e)
        {
            dgvCategories.DataSource=clsCategoriesBLL.GetAllCategories();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewEditCategory frm=new frmAddNewEditCategory((int)dgvCategories.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

        }

       
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Delete This Category ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                return;
            if (clsCategoriesBLL.DeleteByID((int)dgvCategories.CurrentRow.Cells[0].Value))
                MessageBox.Show("Deleted Sucssfully", " don", MessageBoxButtons.OK);
            else
                MessageBox.Show("Deleted is Fail", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            frmCategoriesList_Load(null, null);

        }
    }
}
