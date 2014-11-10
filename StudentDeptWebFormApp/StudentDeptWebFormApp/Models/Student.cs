using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentDeptWebFormApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string RegNo { get; set; }

        public Student(string name, string email, string regNo):this()
        {
            Name = name;
            Email = email;
            RegNo = regNo;
        }

        public Student(string regNo):this()
        {
            RegNo = regNo;
        }

        public Student()
        {
        }

    }
}