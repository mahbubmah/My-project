using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using StudentDeptWebFormApp.Models;

namespace StudentDeptWebFormApp.DAL
{
    public class StudentEntryGateway:Gateway
    {
        private Dept aDept;
        private Student aStudent;
        
        public StudentEntryGateway(): base("sqlcon"){}

        public string InsertStudent(Student aStudent)
        {
            string msg=string.Empty;
            try
            {
                Connection.Open();
                string query = string.Format("INSERT INTO Table_Student VALUES('{0}','{1}','{2}')",aStudent.Name,aStudent.Email,aStudent.RegNo);
                Command.CommandText = query;
                int rowAffected = Command.ExecuteNonQuery();
                Connection.Close();
                msg = "Insertion Failed";
                if (rowAffected > 0)
                {
                    msg = "Insertion Success";
                }
                return msg;     
            }
            catch (Exception exception)
            {
                throw new Exception("Student entry failed",exception);
            }
        }


        public List<Student> GetAllStudnet()
        {
            List<Student> aStudents=new List<Student>();

            try
            {
                Connection.Open();
                string query = string.Format("SELECT * FROM Table_Student");
                Command.CommandText = query;
                SqlDataReader aReader = Command.ExecuteReader();
                
                bool hasRow = aReader.HasRows;

                if (hasRow)
                {
                    while (aReader.Read())
                    {
                        aStudent=new Student();
                        aStudent.Id = (int)aReader[0];
                        aStudent.Name = aReader[1].ToString();
                        aStudent.Email = aReader[2].ToString();
                        aStudent.RegNo = aReader[3].ToString();
                        aStudents.Add(aStudent);
                    }
                    
                }
                Connection.Close();
                
            }
            catch (Exception ex)
            {
                throw new Exception("Connection failed",ex);
            }
            return aStudents;
        }

        public Student GetStudentByRegNo(string regNo)
        {

            try
            {
                Connection.Open();
                string query = string.Format("SELECT * FROM Table_Student WHERE RegNo='{0}'",regNo);
                Command.CommandText = query;
                SqlDataReader aReader = Command.ExecuteReader();

                bool hasRow = aReader.HasRows;

                if (hasRow)
                {
                    while (aReader.Read())
                    {
                        aStudent = new Student();
                        aStudent.Id = (int)aReader[0];
                        aStudent.Name = aReader[1].ToString();
                        aStudent.Email = aReader[2].ToString();
                        aStudent.RegNo = aReader[3].ToString();
                    }
                }
                Connection.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Connection failed", ex);
            }
            return aStudent;

        }

        
    }
}