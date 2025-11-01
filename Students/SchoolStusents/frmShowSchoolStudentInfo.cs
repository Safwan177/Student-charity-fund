using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student.SchoolStusents
{
    public partial class frmShowSchoolStudentInfo : Form
    {
        public frmShowSchoolStudentInfo(int SchoolStudentID)
        {
            InitializeComponent();
            _SchoolStudentID = SchoolStudentID;
        }
        private int _SchoolStudentID = -1;
        private void btnCloce_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowSchoolStudentInfo_Load(object sender, EventArgs e)
        {
            ucSchoolStudentInfo1.LoadStudenInfoByID(_SchoolStudentID);
        }
    }
}
