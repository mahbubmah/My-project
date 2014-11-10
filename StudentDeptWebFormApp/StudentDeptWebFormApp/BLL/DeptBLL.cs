using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentDeptWebFormApp.DAL;
using StudentDeptWebFormApp.Models;

namespace StudentDeptWebFormApp.BLL
{
    public class DeptBLL
    {
        private DeptEntryGateway aDeptEntryGateway;
        public Student Student { get; set; }
        public Dept Dept { get; set; }

        public string AddDept(Dept aDept)
        {
            aDeptEntryGateway=new DeptEntryGateway();
            return aDeptEntryGateway.InsertIntoStudent(aDept);
        }

        public List<Dept> GetAllDeptsBll()
        {
            aDeptEntryGateway=new DeptEntryGateway();
            return aDeptEntryGateway.GetAllDepts();
        }

    }
}