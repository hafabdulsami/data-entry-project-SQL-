namespace homeProject1
{
    partial class Form2
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
            this.Nextbutton = new System.Windows.Forms.Button();
            this.Save2button = new System.Windows.Forms.Button();
            this.SemesterLabel = new System.Windows.Forms.Label();
            this.TeachernameLabel = new System.Windows.Forms.Label();
            this.SemesterBox = new System.Windows.Forms.TextBox();
            this.TeacherNameBox = new System.Windows.Forms.TextBox();
            this.StudentNameBox = new System.Windows.Forms.TextBox();
            this.StudentnameLabel = new System.Windows.Forms.Label();
            this.CourseNameLabel = new System.Windows.Forms.Label();
            this.CourseIdLabel = new System.Windows.Forms.Label();
            this.CourseNamebox = new System.Windows.Forms.TextBox();
            this.CourseIDbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Nextbutton
            // 
            this.Nextbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Nextbutton.Location = new System.Drawing.Point(457, 319);
            this.Nextbutton.Name = "Nextbutton";
            this.Nextbutton.Size = new System.Drawing.Size(75, 23);
            this.Nextbutton.TabIndex = 23;
            this.Nextbutton.Text = "Next";
            this.Nextbutton.UseVisualStyleBackColor = true;
            this.Nextbutton.Click += new System.EventHandler(this.Nextbutton_Click);
            // 
            // Save2button
            // 
            this.Save2button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Save2button.Location = new System.Drawing.Point(271, 319);
            this.Save2button.Name = "Save2button";
            this.Save2button.Size = new System.Drawing.Size(75, 23);
            this.Save2button.TabIndex = 22;
            this.Save2button.Text = "Save";
            this.Save2button.UseVisualStyleBackColor = true;
            this.Save2button.Click += new System.EventHandler(this.Save2button_Click);
            // 
            // SemesterLabel
            // 
            this.SemesterLabel.AutoSize = true;
            this.SemesterLabel.Location = new System.Drawing.Point(268, 260);
            this.SemesterLabel.Name = "SemesterLabel";
            this.SemesterLabel.Size = new System.Drawing.Size(54, 13);
            this.SemesterLabel.TabIndex = 21;
            this.SemesterLabel.Text = "Semester:";
            this.SemesterLabel.Click += new System.EventHandler(this.SemesterLabel_Click);
            // 
            // TeachernameLabel
            // 
            this.TeachernameLabel.AutoSize = true;
            this.TeachernameLabel.Location = new System.Drawing.Point(268, 222);
            this.TeachernameLabel.Name = "TeachernameLabel";
            this.TeachernameLabel.Size = new System.Drawing.Size(84, 13);
            this.TeachernameLabel.TabIndex = 20;
            this.TeachernameLabel.Text = "Teacher Name :";
            this.TeachernameLabel.Click += new System.EventHandler(this.TeachernameLabel_Click);
            // 
            // SemesterBox
            // 
            this.SemesterBox.Location = new System.Drawing.Point(398, 253);
            this.SemesterBox.Name = "SemesterBox";
            this.SemesterBox.Size = new System.Drawing.Size(134, 20);
            this.SemesterBox.TabIndex = 19;
            this.SemesterBox.TextChanged += new System.EventHandler(this.SemesterBox_TextChanged);
            // 
            // TeacherNameBox
            // 
            this.TeacherNameBox.Location = new System.Drawing.Point(398, 215);
            this.TeacherNameBox.Name = "TeacherNameBox";
            this.TeacherNameBox.Size = new System.Drawing.Size(134, 20);
            this.TeacherNameBox.TabIndex = 18;
            this.TeacherNameBox.TextChanged += new System.EventHandler(this.TeacherNameBox_TextChanged);
            // 
            // StudentNameBox
            // 
            this.StudentNameBox.Location = new System.Drawing.Point(398, 180);
            this.StudentNameBox.Name = "StudentNameBox";
            this.StudentNameBox.Size = new System.Drawing.Size(134, 20);
            this.StudentNameBox.TabIndex = 17;
            this.StudentNameBox.TextChanged += new System.EventHandler(this.StudentNameBox_TextChanged);
            // 
            // StudentnameLabel
            // 
            this.StudentnameLabel.AutoSize = true;
            this.StudentnameLabel.Location = new System.Drawing.Point(268, 187);
            this.StudentnameLabel.Name = "StudentnameLabel";
            this.StudentnameLabel.Size = new System.Drawing.Size(81, 13);
            this.StudentnameLabel.TabIndex = 16;
            this.StudentnameLabel.Text = "Student Name :";
            this.StudentnameLabel.Click += new System.EventHandler(this.StudentnameLabel_Click);
            // 
            // CourseNameLabel
            // 
            this.CourseNameLabel.AutoSize = true;
            this.CourseNameLabel.Location = new System.Drawing.Point(268, 152);
            this.CourseNameLabel.Name = "CourseNameLabel";
            this.CourseNameLabel.Size = new System.Drawing.Size(77, 13);
            this.CourseNameLabel.TabIndex = 15;
            this.CourseNameLabel.Text = "Course Name :";
            this.CourseNameLabel.Click += new System.EventHandler(this.CourseNameLabel_Click);
            // 
            // CourseIdLabel
            // 
            this.CourseIdLabel.AutoSize = true;
            this.CourseIdLabel.Location = new System.Drawing.Point(268, 116);
            this.CourseIdLabel.Name = "CourseIdLabel";
            this.CourseIdLabel.Size = new System.Drawing.Size(60, 13);
            this.CourseIdLabel.TabIndex = 14;
            this.CourseIdLabel.Text = "Course ID :";
            this.CourseIdLabel.Click += new System.EventHandler(this.CourseIdLabel_Click);
            // 
            // CourseNamebox
            // 
            this.CourseNamebox.AcceptsReturn = true;
            this.CourseNamebox.Location = new System.Drawing.Point(398, 145);
            this.CourseNamebox.Name = "CourseNamebox";
            this.CourseNamebox.Size = new System.Drawing.Size(134, 20);
            this.CourseNamebox.TabIndex = 13;
            this.CourseNamebox.TextChanged += new System.EventHandler(this.CourseNamebox_TextChanged);
            // 
            // CourseIDbox
            // 
            this.CourseIDbox.Location = new System.Drawing.Point(398, 109);
            this.CourseIDbox.Name = "CourseIDbox";
            this.CourseIDbox.Size = new System.Drawing.Size(134, 20);
            this.CourseIDbox.TabIndex = 12;
            this.CourseIDbox.TextChanged += new System.EventHandler(this.CourseIDbox_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Nextbutton);
            this.Controls.Add(this.Save2button);
            this.Controls.Add(this.SemesterLabel);
            this.Controls.Add(this.TeachernameLabel);
            this.Controls.Add(this.SemesterBox);
            this.Controls.Add(this.TeacherNameBox);
            this.Controls.Add(this.StudentNameBox);
            this.Controls.Add(this.StudentnameLabel);
            this.Controls.Add(this.CourseNameLabel);
            this.Controls.Add(this.CourseIdLabel);
            this.Controls.Add(this.CourseNamebox);
            this.Controls.Add(this.CourseIDbox);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Nextbutton;
        private System.Windows.Forms.Button Save2button;
        private System.Windows.Forms.Label SemesterLabel;
        private System.Windows.Forms.Label TeachernameLabel;
        private System.Windows.Forms.TextBox SemesterBox;
        private System.Windows.Forms.TextBox TeacherNameBox;
        private System.Windows.Forms.TextBox StudentNameBox;
        private System.Windows.Forms.Label StudentnameLabel;
        private System.Windows.Forms.Label CourseNameLabel;
        private System.Windows.Forms.Label CourseIdLabel;
        private System.Windows.Forms.TextBox CourseNamebox;
        private System.Windows.Forms.TextBox CourseIDbox;
    }
}