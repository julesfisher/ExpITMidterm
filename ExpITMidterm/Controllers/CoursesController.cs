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
            var _context = new StudentData();
            var courses = _context.Courses.ToList();
            return View(courses);
        }

        // GET: Courses List
        public ActionResult AddCourse()
        {
            return View();
        }

        // GET: Courses List
        public ActionResult EditCourse()
        {
            return View();
        }

        // GET: Courses List
        public ActionResult UpdateCourse()
        {
            return View();
        }

        // GET: Courses List
        public ActionResult DeleteCourse()
        {
            return View();
        }
    }
}