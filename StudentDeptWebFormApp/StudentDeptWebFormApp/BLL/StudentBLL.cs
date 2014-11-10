using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentDeptWebFormApp.DAL;
using StudentDeptWebFormApp.Models;

namespace StudentDeptWebFormApp.BLL
{
    public class StudentBLL
    {
        private StudentEntryGateway aStudentEntryGateway;
        public string InsertStudentBll(Student aStudent)
        {
            aStudentEntryGateway=new StudentEntryGateway();
            return aStudentEntryGateway.InsertStudent(aStudent);
        }

        public List<Student> GetAllStudentBll()
        {
            aStudentEntryGateway=new StudentEntryGateway();
            return aStudentEntryGateway.GetAllStudnet();

        }

        public Student GetStudentByRegNo(string regNo)
        {
            aStudentEntryGateway=new StudentEntryGateway();
            return aStudentEntryGateway.GetStudentByRegNo(regNo);
        }
    }

}