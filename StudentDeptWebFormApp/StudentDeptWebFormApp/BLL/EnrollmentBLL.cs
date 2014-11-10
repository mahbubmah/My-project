using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentDeptWebFormApp.DAL;
using StudentDeptWebFormApp.Models;

namespace StudentDeptWebFormApp.BLL
{
    public class EnrollmentBLL
    {
        private Enrollment aEnrollment;
        private EnrollmentGateway aEnrollmentGateway;

        public string EnrollStudent(int studentId,int deptId, string dateTime)
        {
            aEnrollmentGateway=new EnrollmentGateway();
            return aEnrollmentGateway.EnrollStudent(studentId, deptId, dateTime);
        }
    }
}