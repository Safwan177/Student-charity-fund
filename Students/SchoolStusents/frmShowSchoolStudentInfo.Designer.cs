namespace student.SchoolStusents
{
    partial class frmShowSchoolStudentInfo
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
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnCloce = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ucSchoolStudentInfo1 = new student.SchoolStusents.ucSchoolStudentInfo();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(311, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(460, 42);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "School Student Info";
            // 
            // btnCloce
            // 
            this.btnCloce.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCloce.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCloce.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCloce.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCloce.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(126)))));
            this.btnCloce.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloce.ForeColor = System.Drawing.Color.White;
            this.btnCloce.Location = new System.Drawing.Point(858, 491);
            this.btnCloce.Name = "btnCloce";
            this.btnCloce.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnCloce.Size = new System.Drawing.Size(143, 48);
            this.btnCloce.TabIndex = 28;
            this.btnCloce.Text = "Close";
            this.btnCloce.Click += new System.EventHandler(this.btnCloce_Click);
            // 
            // ucSchoolStudentInfo1
            // 
            this.ucSchoolStudentInfo1.Location = new System.Drawing.Point(1, 100);
            this.ucSchoolStudentInfo1.Name = "ucSchoolStudentInfo1";
            this.ucSchoolStudentInfo1.Size = new System.Drawing.Size(1070, 366);
            this.ucSchoolStudentInfo1.TabIndex = 30;
            // 
            // frmShowSchoolStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 549);
            this.Controls.Add(this.ucSchoolStudentInfo1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCloce);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmShowSchoolStudentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Student Info";
            this.Load += new System.EventHandler(this.frmShowSchoolStudentInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2CircleButton btnCloce;
        private ucSchoolStudentInfo ucSchoolStudentInfo1;
    }
}