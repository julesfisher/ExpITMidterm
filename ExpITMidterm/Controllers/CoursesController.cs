using ExpITMidterm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExpITMidterm.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses List
        public ActionResult Index()
        {
            var _context = new StudentContext();
            var courses = _context.Courses.ToList();
            return View(courses);
        }

        // GET: Add Course
        public ActionResult AddCourse()
        {
            return View();
        }

        // GET: Edit Course
        public ActionResult EditCourse()
        {
            return View();
        }

        // GET: Update Course
        public ActionResult UpdateCourse()
        {
            return View();
        }

        // GET: Delete Course
        public ActionResult DeleteCourse()
        {
            return View();
        }
    }
}