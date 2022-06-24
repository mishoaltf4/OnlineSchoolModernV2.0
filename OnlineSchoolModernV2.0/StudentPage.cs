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
    public partial class StudentPage : Form
    {
        Student student;
        public StudentPage(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void StudentPage_Load(object sender, EventArgs e)
        {
            label1.Text = student.name;
        }
    }
}
