using ExpITMidterm.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ExpITMidterm.Controllers
{
    public class CoursesController : Controller
    {
        private StudentContext db = new StudentContext();

      
        public ActionResult Index()
        {
            return View(db.Courses.ToList());
        }

       
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Courses courses = db.Courses.Find(id);
            if (courses == null)
            {
                return HttpNotFound();
            }
            return View(courses);
        }

      
        public ActionResult Create()
        {
            //var model = new Courses(){};
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create (Courses courses)
        {
            if (ModelState.IsValid)
            {
                db.Courses.Add(courses);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(courses);
        }

        
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Courses courses = db.Courses.Find(id);
            if (courses == null)
            {
                return HttpNotFound();
            }
            return View(courses);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( Courses courses)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courses).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(courses);
        }

      
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Courses courses = db.Courses.Find(id);
            Courses courses = db.Courses.Where(x => x.Id == id).FirstOrDefault();

            if (courses == null)
            {
                return HttpNotFound();
            }
            return View(courses);
        }

       
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Courses courses = db.Courses.Find(id);
            db.Courses.Remove(courses);
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