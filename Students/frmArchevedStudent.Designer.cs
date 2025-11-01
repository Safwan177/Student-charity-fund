namespace student.Students
{
    partial class frmArchivedStudent
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
            this.btnCloce = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnArchived = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ucStudentWhithFiltter1 = new student.ucStudentWhithFiltter();
            this.SuspendLayout();
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
            this.btnCloce.Location = new System.Drawing.Point(596, 507);
            this.btnCloce.Name = "btnCloce";
            this.btnCloce.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnCloce.Size = new System.Drawing.Size(143, 48);
            this.btnCloce.TabIndex = 119;
            this.btnCloce.Text = "Close";
            // 
            // btnArchived
            // 
            this.btnArchived.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnArchived.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnArchived.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnArchived.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnArchived.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(90)))), ((int)(((byte)(126)))));
            this.btnArchived.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchived.ForeColor = System.Drawing.Color.White;
            this.btnArchived.Location = new System.Drawing.Point(745, 507);
            this.btnArchived.Name = "btnArchived";
            this.btnArchived.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnArchived.Size = new System.Drawing.Size(143, 48);
            this.btnArchived.TabIndex = 118;
            this.btnArchived.Text = "Archived";
            this.btnArchived.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ucStudentWhithFiltter1
            // 
            this.ucStudentWhithFiltter1.Location = new System.Drawing.Point(3, 3);
            this.ucStudentWhithFiltter1.Mode = student.ucStudentWhithFiltter.enMode.School;
            this.ucStudentWhithFiltter1.Name = "ucStudentWhithFiltter1";
            this.ucStudentWhithFiltter1.Size = new System.Drawing.Size(891, 489);
            this.ucStudentWhithFiltter1.TabIndex = 120;
            // 
            // frmArchivedStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 570);
            this.Controls.Add(this.ucStudentWhithFiltter1);
            this.Controls.Add(this.btnCloce);
            this.Controls.Add(this.btnArchived);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmArchivedStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archived Student";
            this.Load += new System.EventHandler(this.frmArchivedStudent_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton btnCloce;
        private Guna.UI2.WinForms.Guna2CircleButton btnArchived;
        private ucStudentWhithFiltter ucStudentWhithFiltter1;
    }
}