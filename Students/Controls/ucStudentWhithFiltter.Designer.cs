namespace student
{
    partial class ucStudentWhithFiltter
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbFillter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.ucSchoolStudentInfo1 = new student.SchoolStusents.ucSchoolStudentInfo();
            this.ucUniversityStudentInfo1 = new student.ucUniversityStudentInfo();
            this.btnSearch = new Guna.UI2.WinForms.Guna2CircleButton();
            this.nn = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dd = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rdbUniversity = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rdbSchool = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnFillter = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnFillter.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(3, 22);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(112, 30);
            this.guna2HtmlLabel1.TabIndex = 45;
            this.guna2HtmlLabel1.Text = "Filtter by:";
            // 
            // cmbFillter
            // 
            this.cmbFillter.BackColor = System.Drawing.Color.Transparent;
            this.cmbFillter.BorderColor = System.Drawing.Color.Black;
            this.cmbFillter.BorderRadius = 10;
            this.cmbFillter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFillter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFillter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFillter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFillter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmbFillter.ForeColor = System.Drawing.Color.Black;
            this.cmbFillter.ItemHeight = 30;
            this.cmbFillter.Items.AddRange(new object[] {
            "None",
            "Student ID",
            "National NO"});
            this.cmbFillter.Location = new System.Drawing.Point(121, 15);
            this.cmbFillter.Name = "cmbFillter";
            this.cmbFillter.Size = new System.Drawing.Size(169, 36);
            this.cmbFillter.StartIndex = 0;
            this.cmbFillter.TabIndex = 44;
            this.cmbFillter.SelectedIndexChanged += new System.EventHandler(this.cmbFillter_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.Black;
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(296, 19);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(229, 36);
            this.txtSearch.TabIndex = 43;
            this.txtSearch.TabStop = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // ucSchoolStudentInfo1
            // 
            this.ucSchoolStudentInfo1.Location = new System.Drawing.Point(28, 87);
            this.ucSchoolStudentInfo1.Name = "ucSchoolStudentInfo1";
            this.ucSchoolStudentInfo1.Size = new System.Drawing.Size(928, 370);
            this.ucSchoolStudentInfo1.TabIndex = 46;
            // 
            // ucUniversityStudentInfo1
            // 
            this.ucUniversityStudentInfo1.Location = new System.Drawing.Point(-5, 87);
            this.ucUniversityStudentInfo1.Name = "ucUniversityStudentInfo1";
            this.ucUniversityStudentInfo1.Size = new System.Drawing.Size(961, 414);
            this.ucUniversityStudentInfo1.TabIndex = 47;
            this.ucUniversityStudentInfo1.Visible = false;
            this.ucUniversityStudentInfo1.Load += new System.EventHandler(this.ucUniversityStudentInfo1_Load);
            // 
            // btnSearch
            // 
            this.btnSearch.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(126)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(531, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSearch.Size = new System.Drawing.Size(75, 62);
            this.btnSearch.TabIndex = 48;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // nn
            // 
            this.nn.AutoSize = false;
            this.nn.BackColor = System.Drawing.Color.Transparent;
            this.nn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nn.Location = new System.Drawing.Point(768, 22);
            this.nn.Name = "nn";
            this.nn.Size = new System.Drawing.Size(108, 24);
            this.nn.TabIndex = 123;
            this.nn.Text = "University";
            // 
            // dd
            // 
            this.dd.AutoSize = false;
            this.dd.BackColor = System.Drawing.Color.Transparent;
            this.dd.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dd.Location = new System.Drawing.Point(654, 22);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(83, 24);
            this.dd.TabIndex = 122;
            this.dd.Text = "School";
            // 
            // rdbUniversity
            // 
            this.rdbUniversity.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbUniversity.CheckedState.BorderThickness = 0;
            this.rdbUniversity.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbUniversity.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbUniversity.Location = new System.Drawing.Point(742, 26);
            this.rdbUniversity.Name = "rdbUniversity";
            this.rdbUniversity.Size = new System.Drawing.Size(20, 20);
            this.rdbUniversity.TabIndex = 121;
            this.rdbUniversity.Text = "guna2CustomRadioButton2";
            this.rdbUniversity.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbUniversity.UncheckedState.BorderThickness = 2;
            this.rdbUniversity.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbUniversity.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbUniversity.CheckedChanged += new System.EventHandler(this.rdbMail_CheckedChanged);
            // 
            // rdbSchool
            // 
            this.rdbSchool.Checked = true;
            this.rdbSchool.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbSchool.CheckedState.BorderThickness = 0;
            this.rdbSchool.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbSchool.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbSchool.Location = new System.Drawing.Point(628, 26);
            this.rdbSchool.Name = "rdbSchool";
            this.rdbSchool.Size = new System.Drawing.Size(20, 20);
            this.rdbSchool.TabIndex = 120;
            this.rdbSchool.Text = "guna2CustomRadioButton1";
            this.rdbSchool.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbSchool.UncheckedState.BorderThickness = 2;
            this.rdbSchool.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbSchool.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbSchool.CheckedChanged += new System.EventHandler(this.RdbFemal_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pnFillter
            // 
            this.pnFillter.Controls.Add(this.guna2HtmlLabel1);
            this.pnFillter.Controls.Add(this.nn);
            this.pnFillter.Controls.Add(this.txtSearch);
            this.pnFillter.Controls.Add(this.dd);
            this.pnFillter.Controls.Add(this.cmbFillter);
            this.pnFillter.Controls.Add(this.rdbUniversity);
            this.pnFillter.Controls.Add(this.btnSearch);
            this.pnFillter.Controls.Add(this.rdbSchool);
            this.pnFillter.Location = new System.Drawing.Point(9, 8);
            this.pnFillter.Name = "pnFillter";
            this.pnFillter.Size = new System.Drawing.Size(895, 80);
            this.pnFillter.TabIndex = 124;
            this.pnFillter.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ucStudentWhithFiltter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnFillter);
            this.Controls.Add(this.ucUniversityStudentInfo1);
            this.Controls.Add(this.ucSchoolStudentInfo1);
            this.Name = "ucStudentWhithFiltter";
            this.Size = new System.Drawing.Size(933, 524);
            this.Load += new System.EventHandler(this.ucStudentWhithFiltter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnFillter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFillter;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private SchoolStusents.ucSchoolStudentInfo ucSchoolStudentInfo1;
        private ucUniversityStudentInfo ucUniversityStudentInfo1;
        private Guna.UI2.WinForms.Guna2CircleButton btnSearch;
        private Guna.UI2.WinForms.Guna2HtmlLabel nn;
        private Guna.UI2.WinForms.Guna2HtmlLabel dd;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdbUniversity;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdbSchool;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel pnFillter;
    }
}
