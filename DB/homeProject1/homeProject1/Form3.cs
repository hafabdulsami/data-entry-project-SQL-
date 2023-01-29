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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Save3button_Click(object sender, EventArgs e)
        {

            if ((StudentIDbox.Text.Length > 0) && (studenttNamebox.Text.Length > 0) && (CourseName3Box.Text.Length > 0) && (MarksBox.Text.Length > 0) && (GradeBox.Text.Length > 0) &&(Section3Box.Text.Length>0) && (semester3Box.Text.Length > 0 ) &&(Session3Box.Text.Length > 0 ) )
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into Course values (@studentId,@studentName,@coursetName,@Marks,@grade,@section,@semester,@section", con);
                cmd.Parameters.AddWithValue("@studentId", StudentIDbox.Text);
                cmd.Parameters.AddWithValue("@studentName", studenttNamebox.Text);
                cmd.Parameters.AddWithValue("@courseName", CourseName3Box.Text);
                cmd.Parameters.AddWithValue("@Marks", MarksBox.Text);
                cmd.Parameters.AddWithValue("@grade", GradeBox.Text);
                cmd.Parameters.AddWithValue("@section", Section3Box.Text);
                cmd.Parameters.AddWithValue("@semester", semester3Box.Text);
                cmd.Parameters.AddWithValue("@session", Session3Box.Text);
            }
        }
    }
}
