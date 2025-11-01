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
namespace student.Categories
{
    public partial class frmAddNewEditCategory : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        private clsCategoriesBLL _category = new clsCategoriesBLL();
        public frmAddNewEditCategory()
        {
            InitializeComponent();
            lblTitle.Text = "Add New Category";
            this.Text = "Add New Category";
            Mode = enMode.AddNew;
        }
        public frmAddNewEditCategory(int CategoryID)
        {
            InitializeComponent();
            lblTitle.Text = "Update Category";
            this.Text = "Update Category";
            Mode = enMode.Update;
            _CategoryID = CategoryID;
        }
        private int _CategoryID = -1;
        private void AddNewEditCategory_Load(object sender, EventArgs e)
        {
            if(Mode == enMode.Update)
            {
                _loadData();
                txtCategoryName.Enabled= false;
                txtDiscription.Enabled= false;
            }
        }

        private void _loadData() 
        {
            _category = clsCategoriesBLL.GetCategoryInfoByID(_CategoryID);
            txtAmount.Text= _category.Amount.ToString();
            txtCategoryName.Text= _category.CategoryName.ToString();
            txtDiscription.Text= _category.Description.ToString();
            lblID.Text= _category.CategoryID.ToString();  

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            _category.Description = txtDiscription.Text;
            _category.Amount = Convert.ToDecimal(txtAmount.Text);
            _category.CategoryName = txtCategoryName.Text;

            if (_category.Save())
            {
                MessageBox.Show("Category Saved Seccsessfuly.", "Save", MessageBoxButtons.OK);
                lblID.Text = _category.CategoryID.ToString();
                Mode = enMode.Update;
            }
            else
            {
                MessageBox.Show("Category Saved Has Fail.", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCloce_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
