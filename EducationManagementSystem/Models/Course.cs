using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EducationManagementSystem.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public Teacher SelectTeacher { get; set; }
    }
}