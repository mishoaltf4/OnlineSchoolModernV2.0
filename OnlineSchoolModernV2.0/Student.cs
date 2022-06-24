﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSchoolModernV2._0
{
    public  class Student
    {
        public string status, name, surname, email, password, gender, city, school;
        public int ID, schoolClass;

        public Student(string name, string surname, string email, string password, string gender, string city, string school, int schoolClass, int ID = -1)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.password = password;
            this.gender = gender;
            this.city = city;
            this.school = school;
            this.schoolClass = schoolClass;  
            this.status = "Student";
        }
    }
}