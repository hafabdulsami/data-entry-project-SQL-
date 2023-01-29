namespace homeProject1
{
    partial class Form1
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
            this.RegistrationNumberbox = new System.Windows.Forms.TextBox();
            this.Namebox = new System.Windows.Forms.TextBox();
            this.RegistrationNumberLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.DepartmentBox = new System.Windows.Forms.TextBox();
            this.sessionBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.sessionLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.Savebutton = new System.Windows.Forms.Button();
            this.Nextbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegistrationNumberbox
            // 
            this.RegistrationNumberbox.Location = new System.Drawing.Point(314, 35);
            this.RegistrationNumberbox.Name = "RegistrationNumberbox";
            this.RegistrationNumberbox.Size = new System.Drawing.Size(134, 20);
            this.RegistrationNumberbox.TabIndex = 0;
            this.RegistrationNumberbox.TextChanged += new System.EventHandler(this.RegistrationNumberbox_TextChanged);
            // 
            // Namebox
            // 
            this.Namebox.Location = new System.Drawing.Point(314, 71);
            this.Namebox.Name = "Namebox";
            this.Namebox.Size = new System.Drawing.Size(134, 20);
            this.Namebox.TabIndex = 1;
            this.Namebox.TextChanged += new System.EventHandler(this.Namebox_TextChanged);
            // 
            // RegistrationNumberLabel
            // 
            this.RegistrationNumberLabel.AutoSize = true;
            this.RegistrationNumberLabel.Location = new System.Drawing.Point(184, 42);
            this.RegistrationNumberLabel.Name = "RegistrationNumberLabel";
            this.RegistrationNumberLabel.Size = new System.Drawing.Size(106, 13);
            this.RegistrationNumberLabel.TabIndex = 2;
            this.RegistrationNumberLabel.Text = "RegistrationNumber :";
            this.RegistrationNumberLabel.Click += new System.EventHandler(this.RegistrationNumberLabel_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(184, 78);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(41, 13);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name :";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Location = new System.Drawing.Point(184, 113);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(68, 13);
            this.DepartmentLabel.TabIndex = 4;
            this.DepartmentLabel.Text = "Department :";
            this.DepartmentLabel.Click += new System.EventHandler(this.DepartmentLabel_Click);
            // 
            // DepartmentBox
            // 
            this.DepartmentBox.Location = new System.Drawing.Point(314, 106);
            this.DepartmentBox.Name = "DepartmentBox";
            this.DepartmentBox.Size = new System.Drawing.Size(134, 20);
            this.DepartmentBox.TabIndex = 5;
            this.DepartmentBox.TextChanged += new System.EventHandler(this.DepartmentBox_TextChanged);
            // 
            // sessionBox
            // 
            this.sessionBox.Location = new System.Drawing.Point(314, 141);
            this.sessionBox.Name = "sessionBox";
            this.sessionBox.Size = new System.Drawing.Size(134, 20);
            this.sessionBox.TabIndex = 6;
            this.sessionBox.TextChanged += new System.EventHandler(this.sessionBox_TextChanged);
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(314, 179);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(134, 20);
            this.addressBox.TabIndex = 7;
            this.addressBox.TextChanged += new System.EventHandler(this.addressBox_TextChanged);
            // 
            // sessionLabel
            // 
            this.sessionLabel.AutoSize = true;
            this.sessionLabel.Location = new System.Drawing.Point(184, 148);
            this.sessionLabel.Name = "sessionLabel";
            this.sessionLabel.Size = new System.Drawing.Size(50, 13);
            this.sessionLabel.TabIndex = 8;
            this.sessionLabel.Text = "Session :";
            this.sessionLabel.Click += new System.EventHandler(this.sessionLabel_Click);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(184, 186);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(51, 13);
            this.AddressLabel.TabIndex = 9;
            this.AddressLabel.Text = "Address :";
            this.AddressLabel.Click += new System.EventHandler(this.AddressLabel_Click);
            // 
            // Savebutton
            // 
            this.Savebutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Savebutton.Location = new System.Drawing.Point(187, 245);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(75, 23);
            this.Savebutton.TabIndex = 10;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // Nextbutton
            // 
            this.Nextbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Nextbutton.Location = new System.Drawing.Point(373, 245);
            this.Nextbutton.Name = "Nextbutton";
            this.Nextbutton.Size = new System.Drawing.Size(75, 23);
            this.Nextbutton.TabIndex = 11;
            this.Nextbutton.Text = "Next";
            this.Nextbutton.UseVisualStyleBackColor = true;
            this.Nextbutton.Click += new System.EventHandler(this.Nextbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Nextbutton);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.sessionLabel);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.sessionBox);
            this.Controls.Add(this.DepartmentBox);
            this.Controls.Add(this.DepartmentLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.RegistrationNumberLabel);
            this.Controls.Add(this.Namebox);
            this.Controls.Add(this.RegistrationNumberbox);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RegistrationNumberbox;
        private System.Windows.Forms.TextBox Namebox;
        private System.Windows.Forms.Label RegistrationNumberLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DepartmentLabel;
        private System.Windows.Forms.TextBox DepartmentBox;
        private System.Windows.Forms.TextBox sessionBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label sessionLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button Nextbutton;
    }
}

