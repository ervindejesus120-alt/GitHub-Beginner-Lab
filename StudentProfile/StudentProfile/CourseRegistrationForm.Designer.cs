namespace StudentProfile
{
    partial class CourseRegistrationForm
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
            cmbStudents = new ComboBox();
            lblStudentInfo = new Label();
            SuspendLayout();
            // 
            // cmbStudents
            // 
            cmbStudents.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbStudents.FormattingEnabled = true;
            cmbStudents.Location = new Point(30, 158);
            cmbStudents.Name = "cmbStudents";
            cmbStudents.Size = new Size(223, 29);
            cmbStudents.TabIndex = 0;
            cmbStudents.SelectedIndexChanged += cmbStudents_SelectedIndexChanged;
            // 
            // lblStudentInfo
            // 
            lblStudentInfo.AutoSize = true;
            lblStudentInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentInfo.Location = new Point(58, 134);
            lblStudentInfo.Name = "lblStudentInfo";
            lblStudentInfo.Size = new Size(0, 21);
            lblStudentInfo.TabIndex = 1;
            // 
            // CourseRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStudentInfo);
            Controls.Add(cmbStudents);
            Name = "CourseRegistrationForm";
            Text = "CourseRegistrationForm";
            Load += CourseRegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbStudents;
        private Label lblStudentInfo;
    }
}