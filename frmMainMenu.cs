using student.Categories;
using student.ScoolStusents;
using student.Students;
using student.Students.SchoolStusents;
using student.Students.UniversityStudents;
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
using student.Users;
using student.Login;
using student.Donations;
using student.Donors;

namespace student
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu(frmLoginScreen frm)
        {
            InitializeComponent();
            _frm=frm;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.White;
                }
            }
        }
        frmLoginScreen _frm;
        private void btnUnivercityStudents_Click(object sender, EventArgs e)
        {
            frmUnevirsityStudent frm = new frmUnevirsityStudent();
            frm.ShowDialog();
        }


        private void universityStudentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnevirsityStudent frm = new frmUnevirsityStudent();
            frm.ShowDialog();
        }

        private void addUnivercityStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUniversityStudent frm = new frmAddEditUniversityStudent();
            frm.ShowDialog();
        }

        private void howDidntBinefitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUniversityStudentWhoDidntBenefitList frm = new frmUniversityStudentWhoDidntBenefitList();
            frm.ShowDialog();
        }

        private void schoolStudentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSchollStudentsList frm = new frmSchollStudentsList();
            frm.ShowDialog();
        }

        private void addSchoolStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditSchoolStudent frm = new frmAddEditSchoolStudent();
            frm.ShowDialog();
        }

        private void howDidntBenefitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSchoolStudentWhoDidntBenefitList frm = new frmSchoolStudentWhoDidntBenefitList();
            frm.ShowDialog();

        }

        private void archivedStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArchivedStudent frm = new frmArchivedStudent();
            frm.ShowDialog();
        }

        private void addPymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.CurrentUser.Permission & (int)clsUserBLL.enPermission.AddPayment) == (int)clsUserBLL.enPermission.AddPayment)
            {
                frmAddPayment frm = new frmAddPayment();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You dont have permission !", "Exseption", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.CurrentUser.Permission & (int)clsUserBLL.enPermission.Staff) == (int)clsUserBLL.enPermission.Staff)
            {
                frmSteffList frm = new frmSteffList();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You dont have permission !", "Exseption", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void staffToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.CurrentUser.Permission & (int)clsUserBLL.enPermission.Categories) == (int)clsUserBLL.enPermission.Categories)
            {
                frmCategoriesList frm = new frmCategoriesList();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You dont have permission !", "Exseption", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
           
        }



        private void donationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.CurrentUser.Permission & (int)clsUserBLL.enPermission.Donations) == (int)clsUserBLL.enPermission.Donations)
            {
                frmDonationList frm= new frmDonationList();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You dont have permission !", "Exseption", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void StudentsToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {

            if ((clsGlobal.CurrentUser.Permission & (int)clsUserBLL.enPermission.Students) != (int)clsUserBLL.enPermission.Students)
            {
                StudentsToolStripMenuItem.DropDownItems.Clear();
                MessageBox.Show("You dont have permission !", "Exseption", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void donorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.CurrentUser.Permission & (int)clsUserBLL.enPermission.Donors) == (int)clsUserBLL.enPermission.Donors)
            {
                frmDonorList frm = new frmDonorList();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You dont have permission !", "Exseption", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.CurrentUser.Permission & (int)clsUserBLL.enPermission.Users) ==  (int)clsUserBLL.enPermission.Users)
            {
                frmUsersList frm=new frmUsersList();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You dont have permission !", "Exseption", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
