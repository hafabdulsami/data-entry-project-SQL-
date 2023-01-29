using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homeProject1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Save2button_Click(object sender, EventArgs e)
        {
            if ((CourseIDbox.Text.Length > 0) && (CourseNamebox.Text.Length > 0) && (StudentNameBox.Text.Length > 0) && (TeacherNameBox.Text.Length > 0) && (SemesterBox.Text.Length > 0))
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into Course values (@courseId,@courseName,@studentName,@teacherName,@semester", con);
                cmd.Parameters.AddWithValue("@courseId", CourseIDbox.Text);
                cmd.Parameters.AddWithValue("@courseName", CourseNamebox.Text);
                cmd.Parameters.AddWithValue("@studentName", StudentNameBox.Text);
                cmd.Parameters.AddWithValue("@teacherName", TeacherNameBox.Text);
                cmd.Parameters.AddWithValue("@semester", SemesterBox.Text);
            }
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            new Form3();
        }

        private void SemesterLabel_Click(object sender, EventArgs e)
        {

        }

        private void TeachernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void SemesterBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TeacherNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentnameLabel_Click(object sender, EventArgs e)
        {

        }

        private void CourseNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void CourseIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void CourseNamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CourseIDbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
