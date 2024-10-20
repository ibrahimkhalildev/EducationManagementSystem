using EducationManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EducationManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult StudentList()
        {
            List<Student> students = new List<Student>
            {
                new Student
                {
                    StudentId = 1,StudentName = "Md Zihad",
                    SelectCourse = new Course
                    {
                        CourseID = 1,CourseName = "ASP.NET Core Career Track",
                        SelectTeacher = new Teacher { TeacherId =1, TeacherName = "Md. Nafiur Rahman Protik"}
                    }
                },
                new Student
                {
                    StudentId = 2, StudentName = "Shamsul Arifin",
                    SelectCourse = new Course
                    {
                        CourseID = 2, CourseName = "App Development with Flutter",
                        SelectTeacher = new Teacher
                        { TeacherId =1, TeacherName = "Md. Ehsanul Hassan" }
                    }
                },
                new Student
                {
                    StudentId = 3, StudentName ="Samia Bari",
                    SelectCourse = new Course
                    {
                        CourseID= 3,CourseName = "Full Stack Web Development with JavaScript (MERN)",
                        SelectTeacher = new Teacher
                        {TeacherId = 3, TeacherName = "Rabbil Hasan" }
                    }
                },
                new Student
                {
                    StudentId = 4, StudentName = "Md Miyad Hossain",
                    SelectCourse = new Course
                    {
                        CourseID =4, CourseName = "WordPress Theme Development",
                        SelectTeacher = new Teacher
                        { TeacherId =4,TeacherName = "Md. Ehsanul Hassan" }
                    }
                },
                new Student
                {
                    StudentId = 5, StudentName = "Ibrahim Khalil",
                    SelectCourse = new Course
                    {
                        CourseID = 5, CourseName = "ASP.NET Core Career Track",
                        SelectTeacher = new Teacher
                        { TeacherId = 5, TeacherName ="Md. Nafiur Rahman Protik" }
                    }
                }
            };

            return View(students);
        }
    }
}