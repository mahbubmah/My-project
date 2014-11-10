using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using StudentDeptWebFormApp.Models;

namespace StudentDeptWebFormApp.DAL
{
    public class EnrollmentGateway:Gateway
    {
        private Enrollment aEnrollment;
        public EnrollmentGateway(): base("sqlcon"){}

        public string EnrollStudent(int studentId,int deptId,string datetime)
        {
            string msg = "Enrollment failed";
            try
            {
                Connection.Open();
                string query = string.Format("INSERT INTO Table_Enrollment VALUES({0},{1},'{2}')", deptId, studentId, datetime);
                Command.CommandText = query;
                int rowAffected = Command.ExecuteNonQuery();
                Connection.Close();
                
                if (rowAffected > 0)
                {
                    return "Enrollment Successfull";
                }
            }
            catch (Exception exception )
            {
                throw new Exception(msg,exception);
            }
            return msg;
        }

        public Enrollment GetAllInfo()
        {
            try
            {
                Connection.Open();
                string query = string.Format("SELECT * FROM View_Enroll");
                Command.CommandText = query;
                SqlDataReader aReader = Command.ExecuteReader();

                bool hasRow = aReader.HasRows;

                if (hasRow)
                {
                    while (aReader.Read())
                    {
                        aEnrollment = new Enrollment();
                        aEnrollment.AStudent.Name = aReader[0].ToString();
                        aEnrollment.AStudent.Email = aReader[1].ToString();
                        aEnrollment.AStudent.RegNo = aReader[2].ToString();
                        aEnrollment.ADept.Title = aReader[3].ToString();
                        aEnrollment.ADatetime = (DateTime)aReader[4];

                    }

                }
                Connection.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Connection failed", ex);
            }
            return aEnrollment;
        }
    }
}