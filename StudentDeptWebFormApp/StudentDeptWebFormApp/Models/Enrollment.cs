using System;

namespace StudentDeptWebFormApp.Models
{
    public class Enrollment
    {
        public Student AStudent { get; set; }
        public Dept ADept { get; set; }
        public DateTime ADatetime { get; set; }
    }
}