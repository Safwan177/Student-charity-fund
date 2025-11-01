namespace student
{
    partial class frmMainMenu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.univercityStudentsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.universityStudentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUnivercityStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howDidntBinefitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schoolStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schoolStudentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSchoolStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howDidntBenefitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivedStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoriesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(126)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StudentsToolStripMenuItem,
            this.donationsToolStripMenuItem,
            this.addPymentToolStripMenuItem,
            this.donorsToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.CategoriesToolStripMenuItem1,
            this.usersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 20, 0, 20);
            this.menuStrip1.Size = new System.Drawing.Size(1747, 102);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // StudentsToolStripMenuItem
            // 
            this.StudentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.univercityStudentsToolStripMenuItem1,
            this.schoolStudentToolStripMenuItem,
            this.archivedStudentToolStripMenuItem});
            this.StudentsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.StudentsToolStripMenuItem.Name = "StudentsToolStripMenuItem";
            this.StudentsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 30, 5, 0);
            this.StudentsToolStripMenuItem.Size = new System.Drawing.Size(107, 62);
            this.StudentsToolStripMenuItem.Text = " Students";
            this.StudentsToolStripMenuItem.DropDownOpening += new System.EventHandler(this.StudentsToolStripMenuItem_DropDownOpening);
            // 
            // univercityStudentsToolStripMenuItem1
            // 
            this.univercityStudentsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.universityStudentListToolStripMenuItem,
            this.addUnivercityStudentToolStripMenuItem,
            this.howDidntBinefitsToolStripMenuItem});
            this.univercityStudentsToolStripMenuItem1.Name = "univercityStudentsToolStripMenuItem1";
            this.univercityStudentsToolStripMenuItem1.Size = new System.Drawing.Size(267, 32);
            this.univercityStudentsToolStripMenuItem1.Text = "Univercity Students";
            // 
            // universityStudentListToolStripMenuItem
            // 
            this.universityStudentListToolStripMenuItem.Name = "universityStudentListToolStripMenuItem";
            this.universityStudentListToolStripMenuItem.Size = new System.Drawing.Size(301, 32);
            this.universityStudentListToolStripMenuItem.Text = "University Student List";
            this.universityStudentListToolStripMenuItem.Click += new System.EventHandler(this.universityStudentListToolStripMenuItem_Click);
            // 
            // addUnivercityStudentToolStripMenuItem
            // 
            this.addUnivercityStudentToolStripMenuItem.Name = "addUnivercityStudentToolStripMenuItem";
            this.addUnivercityStudentToolStripMenuItem.Size = new System.Drawing.Size(301, 32);
            this.addUnivercityStudentToolStripMenuItem.Text = "Add Univercity Student";
            this.addUnivercityStudentToolStripMenuItem.Click += new System.EventHandler(this.addUnivercityStudentToolStripMenuItem_Click);
            // 
            // howDidntBinefitsToolStripMenuItem
            // 
            this.howDidntBinefitsToolStripMenuItem.Name = "howDidntBinefitsToolStripMenuItem";
            this.howDidntBinefitsToolStripMenuItem.Size = new System.Drawing.Size(301, 32);
            this.howDidntBinefitsToolStripMenuItem.Text = " Who Didnt Benefit";
            this.howDidntBinefitsToolStripMenuItem.Click += new System.EventHandler(this.howDidntBinefitsToolStripMenuItem_Click);
            // 
            // schoolStudentToolStripMenuItem
            // 
            this.schoolStudentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schoolStudentListToolStripMenuItem,
            this.addSchoolStudentToolStripMenuItem,
            this.howDidntBenefitToolStripMenuItem});
            this.schoolStudentToolStripMenuItem.Name = "schoolStudentToolStripMenuItem";
            this.schoolStudentToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.schoolStudentToolStripMenuItem.Text = "School Student";
            // 
            // schoolStudentListToolStripMenuItem
            // 
            this.schoolStudentListToolStripMenuItem.Name = "schoolStudentListToolStripMenuItem";
            this.schoolStudentListToolStripMenuItem.Size = new System.Drawing.Size(273, 32);
            this.schoolStudentListToolStripMenuItem.Text = "School Student List";
            this.schoolStudentListToolStripMenuItem.Click += new System.EventHandler(this.schoolStudentListToolStripMenuItem_Click);
            // 
            // addSchoolStudentToolStripMenuItem
            // 
            this.addSchoolStudentToolStripMenuItem.Name = "addSchoolStudentToolStripMenuItem";
            this.addSchoolStudentToolStripMenuItem.Size = new System.Drawing.Size(273, 32);
            this.addSchoolStudentToolStripMenuItem.Text = "Add School Student";
            this.addSchoolStudentToolStripMenuItem.Click += new System.EventHandler(this.addSchoolStudentToolStripMenuItem_Click);
            // 
            // howDidntBenefitToolStripMenuItem
            // 
            this.howDidntBenefitToolStripMenuItem.Name = "howDidntBenefitToolStripMenuItem";
            this.howDidntBenefitToolStripMenuItem.Size = new System.Drawing.Size(273, 32);
            this.howDidntBenefitToolStripMenuItem.Text = "Who Didnt Benefit";
            this.howDidntBenefitToolStripMenuItem.Click += new System.EventHandler(this.howDidntBenefitToolStripMenuItem_Click);
            // 
            // archivedStudentToolStripMenuItem
            // 
            this.archivedStudentToolStripMenuItem.Name = "archivedStudentToolStripMenuItem";
            this.archivedStudentToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.archivedStudentToolStripMenuItem.Text = "Archived Student";
            this.archivedStudentToolStripMenuItem.Click += new System.EventHandler(this.archivedStudentToolStripMenuItem_Click);
            // 
            // donationsToolStripMenuItem
            // 
            this.donationsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.donationsToolStripMenuItem.Name = "donationsToolStripMenuItem";
            this.donationsToolStripMenuItem.Size = new System.Drawing.Size(116, 62);
            this.donationsToolStripMenuItem.Text = "Donations";
            this.donationsToolStripMenuItem.Click += new System.EventHandler(this.donationsToolStripMenuItem_Click);
            // 
            // addPymentToolStripMenuItem
            // 
            this.addPymentToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addPymentToolStripMenuItem.Name = "addPymentToolStripMenuItem";
            this.addPymentToolStripMenuItem.Size = new System.Drawing.Size(139, 62);
            this.addPymentToolStripMenuItem.Text = " Add Pyment";
            this.addPymentToolStripMenuItem.Click += new System.EventHandler(this.addPymentToolStripMenuItem_Click);
            // 
            // donorsToolStripMenuItem
            // 
            this.donorsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.donorsToolStripMenuItem.Name = "donorsToolStripMenuItem";
            this.donorsToolStripMenuItem.Size = new System.Drawing.Size(90, 62);
            this.donorsToolStripMenuItem.Text = "Donors";
            this.donorsToolStripMenuItem.Click += new System.EventHandler(this.donorsToolStripMenuItem_Click);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(70, 62);
            this.staffToolStripMenuItem.Text = " Staff";
            this.staffToolStripMenuItem.Click += new System.EventHandler(this.staffToolStripMenuItem_Click);
            // 
            // CategoriesToolStripMenuItem1
            // 
            this.CategoriesToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.CategoriesToolStripMenuItem1.Name = "CategoriesToolStripMenuItem1";
            this.CategoriesToolStripMenuItem1.Size = new System.Drawing.Size(124, 62);
            this.CategoriesToolStripMenuItem1.Text = " Categories";
            this.CategoriesToolStripMenuItem1.Click += new System.EventHandler(this.staffToolStripMenuItem1_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(73, 62);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1747, 764);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CategoriesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem univercityStudentsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem universityStudentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUnivercityStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howDidntBinefitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schoolStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schoolStudentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSchoolStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howDidntBenefitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivedStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
    }
}