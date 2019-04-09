using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversitySystem.Models;
using System.Data;


namespace UniversitySystem.Controllers
{
    public class LecturerController : Controller
    {
        //
        UniversitySystemContextDb db = new UniversitySystemContextDb();

        public ActionResult Index()
        {
           

            return View(db.Lecturers.ToList());
        }

        //
        // GET: /Lecturer/Details/5

        public ActionResult Details(int id)
        {
            using (UniversitySystemContextDb db = new UniversitySystemContextDb())
            {

                return View(db.Lecturers.Where(l => l.LecturerId == id).FirstOrDefault());
            }
        }

        //
        // GET: /Lecturer/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Lecturer/Create

        [HttpPost]
        public ActionResult Create(Lecturer newLecturer)
        {
            if (ModelState.IsValid)
            {
                // TODO: Add insert logic here
                db.AddToLecturers(newLecturer);
                db.SaveChanges();


                return RedirectToAction("Index");
            }
            else
            {
                return View(newLecturer);
            }
        }
        
        //
        // GET: /Lecturer/Edit/5
 
        public ActionResult Edit(int id)
        {
           Lecturer lecturer = db.Lecturers.Single(l => l.LecturerId == id);
            if (lecturer == null)
            {
                return View("NotFound");
            }
            // ViewBag.LecturerId = new SelectList(db.Lecturers,"LecturerId","LecturerName",course.CourseId);
            return View(lecturer);
        }

        //
        // POST: /Lecturer/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Lecturer lecturer)
        {
            if (ModelState.IsValid)
            {

                db.Lecturers.Attach(lecturer);
                db.ObjectStateManager.ChangeObjectState(lecturer, EntityState.Modified);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(lecturer);
            }
        }

        //
        // GET: /Lecturer/Delete/5
 
        public ActionResult Delete(int id)
        {
            using (UniversitySystemContextDb db = new UniversitySystemContextDb())
            {
                return View(db.Lecturers.Where(l => l.LecturerId == id).FirstOrDefault());
            }

        }

        //
        // POST: /Lecturer/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (UniversitySystemContextDb db = new UniversitySystemContextDb())
                {
                    Lecturer lecturer = db.Lecturers.Where(l => l.LecturerId == id).FirstOrDefault();
                    db.Lecturers.DeleteObject(lecturer);
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
