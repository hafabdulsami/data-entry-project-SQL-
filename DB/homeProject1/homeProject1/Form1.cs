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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if((RegistrationNumberbox.Text.Length > 0) && (Namebox.Text.Length > 0 )&& (DepartmentBox.Text.Length > 0) && (sessionBox.Text.Length > 0) && (addressBox.Text.Length > 0 )) 
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into Student values (@registrationNumber,@Name,@Department,@Session,@Address", con);
                cmd.Parameters.AddWithValue("@registrationNumber", RegistrationNumberbox.Text);
                cmd.Parameters.AddWithValue("@Name", Namebox.Text);
                cmd.Parameters.AddWithValue("@Department", DepartmentBox.Text);
                cmd.Parameters.AddWithValue("@Session", int.Parse(sessionBox.Text));
                cmd.Parameters.AddWithValue("@Address", addressBox.Text);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            new Form2();
        }

        private void AddressLabel_Click(object sender, EventArgs e)
        {

        }

        private void sessionLabel_Click(object sender, EventArgs e)
        {

        }

        private void addressBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sessionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DepartmentBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DepartmentLabel_Click(object sender, EventArgs e)
        {

        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void Namebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrationNumberbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
