namespace student
{
    partial class frmShowUniversityStudentInfo
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
            this.ucUniversityStudentInfo1 = new student.ucUniversityStudentInfo();
            this.btnCloce = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // ucUniversityStudentInfo1
            // 
            this.ucUniversityStudentInfo1.Location = new System.Drawing.Point(-3, 106);
            this.ucUniversityStudentInfo1.Name = "ucUniversityStudentInfo1";
            this.ucUniversityStudentInfo1.Size = new System.Drawing.Size(1054, 403);
            this.ucUniversityStudentInfo1.TabIndex = 0;
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
            this.btnCloce.Location = new System.Drawing.Point(885, 515);
            this.btnCloce.Name = "btnCloce";
            this.btnCloce.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnCloce.Size = new System.Drawing.Size(143, 48);
            this.btnCloce.TabIndex = 16;
            this.btnCloce.Text = "Close";
            this.btnCloce.Click += new System.EventHandler(this.btnCloce_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(319, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(418, 42);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.Text = "Unversity Student Info";
            // 
            // frmShowUniversityStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 567);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCloce);
            this.Controls.Add(this.ucUniversityStudentInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmShowUniversityStudentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unversity Student Info";
            this.Load += new System.EventHandler(this.frmShowUniversityStudentInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ucUniversityStudentInfo ucUniversityStudentInfo1;
        private Guna.UI2.WinForms.Guna2CircleButton btnCloce;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
    }
}