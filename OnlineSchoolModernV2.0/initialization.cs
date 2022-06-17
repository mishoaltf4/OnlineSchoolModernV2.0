using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineSchoolModernV2._0
{
    public partial class initialization : Form
    {
        public initialization()
        {
            InitializeComponent();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            btnRegistration.Visible = false;
            btnLogin.Visible = false;
            btnTeacher.Visible = true;
            btnStudent.Visible = true;
            btnBack.Visible = true;
            label1.Text = "Choose Status:";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnRegistration.Visible = false;
            btnLogin.Visible = false;
            btnTeacher.Visible = true;
            btnStudent.Visible = true;
            btnBack.Visible = true;
            label1.Text = "Choose Status: ";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(groupBox1.Visible == true)
            {
                groupBox1.Visible = false;
                btnStudent.Visible = true;
                btnTeacher.Visible = true;
            }else if(label1.Text == "Choose Status:")
            {
                btnTeacher.Visible = false;
                btnStudent.Visible = false;
                btnBack.Visible = false;
                btnRegistration.Visible = true;
                btnLogin.Visible = true;
                label1.Text = "Log in / Registration";
            }
            else if(label1.Text == "Choose Status: ")
            {
                btnTeacher.Visible = false;
                btnStudent.Visible = false;
                btnBack.Visible = false;
                btnRegistration.Visible = true;
                btnLogin.Visible = true;
                label1.Text = "Log in / Registration";
            }
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            btnTeacher.Visible = false;
            btnStudent.Visible = false;
            groupBox1.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegisterTeacher_Click(object sender, EventArgs e)
        {

        }
    }
}
