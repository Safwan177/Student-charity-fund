using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student
{
    public partial class frmShowUniversityStudentInfo : Form
    {
        public frmShowUniversityStudentInfo(int UnversityStudent )
        {
            InitializeComponent();
            _UnversityStudent=UnversityStudent;
        }
        private int _UnversityStudent = -1;
        private void btnCloce_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowUniversityStudentInfo_Load(object sender, EventArgs e)
        {
            ucUniversityStudentInfo1.LoadStudenInfo(_UnversityStudent); 
        }
    }
}
