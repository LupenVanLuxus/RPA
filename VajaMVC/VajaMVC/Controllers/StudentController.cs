using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VajaMVC.Models;

namespace VajaMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var studentList = new List<Student>{
                new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentId = 2, StudentName = "Janez", Age = 22 } ,
                new Student() { StudentId = 3, StudentName = "Marija", Age = 24 } ,
                new Student() { StudentId = 4, StudentName = "Tadej", Age = 19 } ,
                new Student() { StudentId = 5, StudentName = "Franci", Age = 20 }
                };
            return View(studentList);
        }
    }
}