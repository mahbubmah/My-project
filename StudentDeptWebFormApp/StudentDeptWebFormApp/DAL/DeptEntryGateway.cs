using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using StudentDeptWebFormApp.Models;

namespace StudentDeptWebFormApp.DAL
{
    public class DeptEntryGateway:Gateway
    {
        private Dept ADept;
        public DeptEntryGateway():base("sqlcon"){}

        public string InsertIntoStudent(Dept aDept)
        {
            try
            {
                Connection.Open();
                string query = String.Format("INSERT INTO Table_Dept VALUES('{0}','{1}')", aDept.Code, aDept.Title);
                Command.CommandText = query;
                int affecterow = Command.ExecuteNonQuery();
                Connection.Close();
                string msg = "Insertion Failed";
                if (affecterow > 0)
                {
                    msg = "Insertion Success";
                }
                return msg;        
                }
                catch (Exception exception)
                {
                    throw new Exception("Insertion Failed",exception);
                }            
        }

        public List<Dept> GetAllDepts()
        {
            List<Dept> aDepts=new List<Dept>();

            try
            {
                Connection.Open();
                string query = string.Format("SELECT * FROM Table_Dept");
                Command.CommandText = query;
                SqlDataReader aReader = Command.ExecuteReader();
                bool hasRow = aReader.HasRows;

                if (hasRow)
                {
                    while (aReader.Read())
                    {
                        ADept = new Dept();
                        ADept.Id = (int)aReader[0];
                        ADept.Code = aReader[1].ToString();
                        ADept.Title = aReader[2].ToString();
                        aDepts.Add(ADept);
                    }
                }
                Connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Connection failed",ex);
            }
            
            return aDepts;
        }


    }
}