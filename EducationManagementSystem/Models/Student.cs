using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EducationManagementSystem.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public Course SelectCourse { get; set; }
    }
}