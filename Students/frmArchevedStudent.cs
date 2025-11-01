using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student.Students
{
    public partial class frmArchivedStudent : Form
    {
        public frmArchivedStudent()
        {
            InitializeComponent();
        }
        public frmArchivedStudent(int StudentID)
        {
            InitializeComponent();
            _StudentID=StudentID;
        }

        public ucStudentWhithFiltter.enMode Mode { set { ucStudentWhithFiltter1.Mode = value; } get { return ucStudentWhithFiltter1.Mode; } }
        private int _StudentID = -1;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to archived this student", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            if (ucStudentWhithFiltter1.Mode == ucStudentWhithFiltter.enMode.School)
            {
                if (ucStudentWhithFiltter1.SchoolStudent.IsArchieved == true)
                {
                    MessageBox.Show("This student is already archived !", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    ucStudentWhithFiltter1.SchoolStudent.IsArchieved = true;
                    if (ucStudentWhithFiltter1.SchoolStudent.Save())
                    {
                        MessageBox.Show("student archived seccsessfuly!", "", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("student archived Failed! !", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
            }
            else
            {
                if (ucStudentWhithFiltter1.UniversituStudent.IsArchieved == true)
                {
                    MessageBox.Show("This student is already archived !", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    ucStudentWhithFiltter1.UniversituStudent.IsArchieved = true;
                    if (ucStudentWhithFiltter1.UniversituStudent.Save())
                    {
                        MessageBox.Show("student archived seccsessfuly!", "", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("student archived Failed! !", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }
        public void _LoadInfo()
        {
            ucStudentWhithFiltter1.LoadStudentData(_StudentID);
        }
        private void frmArchivedStudent_Load(object sender, EventArgs e)
        {
            if (_StudentID != -1)
            {
                _LoadInfo();
            }
        }
    }
}
