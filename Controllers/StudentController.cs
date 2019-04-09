using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversitySystem.Models;
using System.Data;

namespace UniversitySystem.Controllers
{
    public class StudentController : Controller
    {
        //
        UniversitySystemContextDb db = new UniversitySystemContextDb();

        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }

        //
        // GET: /Student/Details/5

        public ActionResult Details(int id)
        {
             using (UniversitySystemContextDb db = new UniversitySystemContextDb())
            {
                return View(db.Students.Where(s => s.StudentId == id).FirstOrDefault());
            }
        }

        //
        // GET: /Student/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Student/Create

        [HttpPost]
        public ActionResult Create(Student newStudent)
        {
            if (ModelState.IsValid)
            {
                // TODO: Add insert logic here
                db.AddToStudents(newStudent);
                db.SaveChanges();


                return RedirectToAction("Index");
            }
            else
            {
                return View(newStudent);
            }
        }
        
        //
        // GET: /Student/Edit/5
 
        public ActionResult Edit(int id)
        {
            Student student = db.Students.Single(s => s.StudentId == id);
            if (student == null)
            {
                return View("NotFound");
            }

            return View(student);
        }

        //
        // POST: /Student/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Student student)
        {
            if (ModelState.IsValid)
            {
                db.Students.Attach(student);
                db.ObjectStateManager.ChangeObjectState(student, EntityState.Modified);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        //
        // GET: /Student/Delete/5
 
        public ActionResult Delete(int id)
        {
            using (UniversitySystemContextDb db = new UniversitySystemContextDb())
            {
                return View(db.Students.Where(s => s.StudentId == id).FirstOrDefault());
            }
        }

        //
        // POST: /Student/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (UniversitySystemContextDb db = new UniversitySystemContextDb())
                {
                    Student student = db.Students.Where(s => s.StudentId == id).FirstOrDefault();
                    db.Students.DeleteObject(student);
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
