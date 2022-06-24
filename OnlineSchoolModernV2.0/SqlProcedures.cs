using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSchoolModernV2._0
{
    internal class SqlProcedures
    {
        public static string connstr = "Data Source=DESKTOP-A4SL53J\\SQLEXPRESS01;Initial Catalog=OnlineSchoolModernV2.0;Integrated Security=True";
        public static SqlConnection conn = new SqlConnection(connstr);
        public static SqlCommand cmd;
        public static SqlDataAdapter dataAdapter;

        public static DataTable RefreshStudent()
        {
            cmd = new SqlCommand("Refresh_student", conn);
            dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public static void newStudent(Student student)
        {
            cmd = new SqlCommand("new_student", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter[] sqlParStudent = new SqlParameter[9];
            sqlParStudent[0] = new SqlParameter("Status", SqlDbType.NVarChar, 50);
            sqlParStudent[0].Value = student.status;
            sqlParStudent[1] = new SqlParameter("Name", SqlDbType.NVarChar, 50);
            sqlParStudent[1].Value = student.name;
            sqlParStudent[2] = new SqlParameter("Surname", SqlDbType.NVarChar, 50);
            sqlParStudent[2].Value = student.surname;
            sqlParStudent[3] = new SqlParameter("Email", SqlDbType.NVarChar, 50);
            sqlParStudent[3].Value = student.email;
            sqlParStudent[4] = new SqlParameter("Password", SqlDbType.NVarChar, 50);
            sqlParStudent[4].Value = student.password;
            sqlParStudent[5] = new SqlParameter("Gender", SqlDbType.NVarChar, 50);
            sqlParStudent[5].Value = student.gender;
            sqlParStudent[6] = new SqlParameter("City", SqlDbType.NVarChar, 50);
            sqlParStudent[6].Value = student.city;
            sqlParStudent[7] = new SqlParameter("School", SqlDbType.NVarChar, 50);
            sqlParStudent[7].Value = student.school;
            sqlParStudent[8] = new SqlParameter("Class", SqlDbType.Int);
            sqlParStudent[8].Value = student.schoolClass;

            conn.Open();
            cmd.Parameters.AddRange(sqlParStudent);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void newTeacher(Teachers teacher)
        {
            cmd = new SqlCommand("new_teacher", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter[] sqlParTeacher = new SqlParameter[8];
            sqlParTeacher[0] = new SqlParameter("Status", SqlDbType.NVarChar, 50);
            sqlParTeacher[0].Value = teacher.status;
        }
    }
}
