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
namespace student
{
    public partial class ucBaseStudentInfo : UserControl
    {
        public ucBaseStudentInfo()
        {
            InitializeComponent();
        }
        public void LoadInfo(int BaseStudentInfo)
        {
            clsStudentBLL studnt = clsStudentBLL.FindStudentByID(BaseStudentInfo);
            if (studnt == null)
            {
                MessageBox.Show("The student is not found!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblAddress.Text = studnt.Address;
            lblCategory.Text = studnt.Category.ToString();
            lblFirstNamr.Text = studnt.FirstName;
            lblSecondName.Text = studnt.SecondName;
            lblLastName.Text = studnt.LastName;
            lblNationalNO.Text = studnt.NationalNO;
            lblNote.Text = studnt.Note;
            lblPhoneNumber.Text = studnt.PhoneNumber;
           // lblID.Text = studnt.StudentID.ToString();
            if (studnt.Gendor)
                lblGendor.Text = "Mail";
            else
                lblGendor.Text = "Femail";

            if (studnt.IsArchieved)
                lblIsArchived.Text = "Yes";
            else
                lblIsArchived.Text = "No";

        }

        private void ucBaseStudentInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
