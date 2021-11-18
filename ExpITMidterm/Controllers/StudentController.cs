using ExpITMidterm.Models;
using ExpITMidterm.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ExpITMidterm.Controllers
{

    public class StudentController : Controller
    {

        private StudentContext db = new StudentContext();

        
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }

        
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Students students = db.Students.Find(id);
            if (students == null)
            {
                return HttpNotFound();
            }
            return View(students);
        }


        [HttpGet]
        
        public ActionResult Create()
        {
            var model = new StudentViewModel()
            {
                Student = new Students(),
                CourseList = db.Courses.ToList()
            };

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create ( StudentViewModel students)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(students.Student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(students);
        }


        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Students students = db.Students.Where(x => x.Id == id).FirstOrDefault();
            if (students == null)
            {
                return HttpNotFound();
            }
            return View(students);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit ( StudentViewModel students)
        {
            if (ModelState.IsValid)
            {
                db.Entry(students).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(students);
        }


        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Students students = db.Students.Find(id);
            if (students == null)
            {
                return HttpNotFound();
            }
            return View(students);
        }



        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Students students = db.Students.Find(id);
            db.Students.Remove(students);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


    }
}