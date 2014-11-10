using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentDeptWebFormApp.Models
{
    public class Dept
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public String Title { get; set; }

        public Dept(string code, string title):this()
        {
            Code = code;
            Title = title;
        }

        public Dept()
        {
        }
    }
}