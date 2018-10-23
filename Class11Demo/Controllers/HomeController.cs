using Microsoft.AspNetCore.Mvc;
using Class11Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class11Demo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Index(string studentName, int studentAge)
        {
            return RedirectToAction("Result", new { studentName, studentAge});

        }

        public ViewResult Result(string studentName, int studentAge)
        {
            Student student = new Student();
            student.Name = studentName;
            student.age = studentAge;
            return View(student);
        }

        public string Cat(string catName="Flash", int catAge=1)
        {
            return $"Hello {catName} you are {catAge} years old";
        }

        public ViewResult Class()
        {
            Student student = new Student();
            student.Name = "Nancy";
            student.age = 12;

            Student s1 = new Student();
            s1.Name = "Amanda";
            s1.age = 51;

            Student s2 = new Student();
            s2.Name = "Molly";
            s2.age = 51;

            Student s3 = new Student();
            s3.Name = "Jeff";
            s3.age = 32;

            List<Student> myStudents = new List<Student> { student, s1, s2, s3 }; 
            return View(myStudents);
        }
    }
}
