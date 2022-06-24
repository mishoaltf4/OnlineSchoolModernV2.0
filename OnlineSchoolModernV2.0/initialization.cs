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


        /*
        
        -- == >> Registration Side << == --

         */

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            btnRegistration.Visible = false;
            btnLogin.Visible = false;
            btnTeacher.Visible = true;
            btnStudent.Visible = true;
            btnBack.Visible = true;
            label1.Text = "Choose Status for new user:";
        }

        // Teacher registration 

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            if(label1.Text == "Choose Status for new user:")
            {
                btnTeacher.Visible = false;
                btnStudent.Visible = false;
                GroupTeacherReg.Visible = true;
            }
            else
            {
                btnTeacher.Visible = false;
                btnStudent.Visible = false;
                groupBoxStudentLogin.Visible = true;
            }
        }

 
        private void btnRegisterTeacher_Click(object sender, EventArgs e)
        {
            //Validation
            if (txtTeacherRegName.Text.Length >= 3 && txtTeacherRegName.Text != " " &&
               txtTeacherRegSurname.Text.Length >= 5 && txtTeacherRegSurname.Text != " " &&
               txtTeacherRegEmail.Text.Length >= 5 && txtTeacherRegEmail.Text != " " &&
               txtTeacherRegPassword.Text.Length >= 7 && txtTeacherRegPassword.Text != " " &&
               txtTeacherRegPasswordToo.Text.Length >= 7 && txtTeacherRegPasswordToo.Text != " " &&
               CBTeachRegGender.Text != " " && CBTeachRegCity.Text != " " && CBTeachRegSchool.Text != " ")
            {
                if (txtTeacherRegPassword.Text == txtTeacherRegPasswordToo.Text)
                {
                    Student students = new Student(txtStudentRegName.Text, txtStudentRegSurname.Text, txtStudentRegEmail.Text, txtStudentRegPassword.Text, CBStudentRegGender.Text, CBStudentRegCity.Text, CBStudentRegSchool.Text, Convert.ToInt32(CBStudentRegClass.Text));
                    SqlProcedures.newStudent(students);
                    MessageBox.Show("Succes!");
                }
                else
                {
                    MessageBox.Show("Passwords do not match. Please check again");
                }
            }
            else
            {
                MessageBox.Show("Some of ur TextBox are empty or short. please fill it out");
            }

        }

        // Student Registration

        private void btnStudent_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Choose Status for new user:")
            {
                btnTeacher.Visible = false;
                btnStudent.Visible = false;
                GroupStudentReg.Visible = true;
            }
            else
            {
                btnTeacher.Visible = false;
                btnStudent.Visible = false;
                groupBoxStudentLogin.Visible = true;
            }
        }

        private void btnStudentReg_Click(object sender, EventArgs e)
        {
            if (txtStudentRegName.Text.Length >= 3 && txtStudentRegName.Text != " " &&
               txtStudentRegSurname.Text.Length >= 5 && txtStudentRegSurname.Text != " " &&
               txtStudentRegEmail.Text.Length >= 5 && txtStudentRegEmail.Text != " " &&
               txtStudentRegPassword.Text.Length >= 7 && txtStudentRegPassword.Text != " " &&
               txtStudentRegToo.Text.Length >= 7 && txtStudentRegToo.Text != " " &&
               CBStudentRegGender.Text != " " && CBStudentRegCity.Text != " " && CBStudentRegSchool.Text != " ")
            {
                if (txtStudentRegPassword.Text == txtStudentRegToo.Text)
                {
                    Student students = new Student(txtStudentRegName.Text, txtStudentRegSurname.Text, txtStudentRegEmail.Text, txtStudentRegPassword.Text, CBStudentRegGender.Text, CBStudentRegCity.Text, CBStudentRegSchool.Text, Convert.ToInt32(CBStudentRegClass.Text));
                    SqlProcedures.newStudent(students);
                    MessageBox.Show("Succes!");
                }
                else
                {
                    MessageBox.Show("Passwords do not match. Please check again");
                }
            }
            else
            {
                MessageBox.Show("Some of ur TextBox are empty or short. please fill it out");
            }
        }



        /*
        
        -- == >> Registration Side [END] << == --

         */


        /*
         
        -- == >> Login Side << == --

         */

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnRegistration.Visible = false;
            btnLogin.Visible = false;
            btnTeacher.Visible = true;
            btnStudent.Visible = true;
            btnBack.Visible = true;
            label1.Text = "Choose Status of ur user:";
        }

        List<Student> userInfo = new List<Student>();

        private void loadStudents()
        {
            DataTable dt = SqlProcedures.RefreshStudent();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                userInfo.Add(new Student(
                    (string)dt.Rows[i]["Name"],
                    (string)dt.Rows[i]["Surname"],
                    (string)dt.Rows[i]["Email"],
                    (string)dt.Rows[i]["Password"],
                    (string)dt.Rows[i]["Gender"],
                    (string)dt.Rows[i]["City"],
                    (string)dt.Rows[i]["School"],
                    (int)dt.Rows[i]["Class"],
                    (int)dt.Rows[i]["ID"]
                    ));
            }
        }


        /*
         
        -- == >> Login side [END] << == --

         */

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (GroupTeacherReg.Visible == true || GroupStudentReg.Visible == true || groupBoxStudentLogin.Visible == true || groupBoxTeacherLogin.Visible == true)
            {
                GroupTeacherReg.Visible = false;
                GroupStudentReg.Visible = false;
                groupBoxStudentLogin.Visible = false;
                groupBoxTeacherLogin.Visible = false;
                btnStudent.Visible = true;
                btnTeacher.Visible = true;
            }else if(label1.Text == "Choose Status for new user:")
            {
                btnTeacher.Visible = false;
                btnStudent.Visible = false;
                btnBack.Visible = false;
                btnRegistration.Visible = true;
                btnLogin.Visible = true;
                label1.Text = "Log in / Registration";
            }
            else if(label1.Text == "Choose Status of ur user:")
            {
                btnTeacher.Visible = false;
                btnStudent.Visible = false;
                btnBack.Visible = false;
                btnRegistration.Visible = true;
                btnLogin.Visible = true;
                label1.Text = "Log in / Registration";
            }
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
            loadStudents();
            foreach (var item in userInfo)
            {
                if(txtStudentLoginEmail.Text == item.email && txtStudentLoginPassword.Text == item.password)
                {
                    StudentPage studentPage = new StudentPage(item);
                    this.Hide();
                    studentPage.Show();
                }
                else
                {
                    MessageBox.Show("email or password is inccorect");
                }
            }
        }
    }
}
