using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversitySystem.Models;
using UniversitySystem.Models.ViewModel;

namespace UniversitySystem.Controllers
{
    public class LecturerEnrollmentController : Controller
    {
        //
        UniversitySystemContextDb db = new UniversitySystemContextDb();
       

        public ActionResult Index()
        {
            List<Lecturer> LecturerList = db.Lecturers.ToList();
            //ViewBag.LecturerList = new SelectList(LecturerList, "LecturerId", "LecturerName");
            return View(db.Lecturers.ToList());
        }
        //
        // GET: /LecturerEnrollment/Details/5

        public ActionResult Details(int id)
        {
            using (UniversitySystemContextDb db = new UniversitySystemContextDb())
            {
                return View(db.Lecturers.Where(l => l.LecturerId == id).FirstOrDefault());
            }
        }

        //
        // GET: /LecturerEnrollment/Create

     

        //
        // POST: /LecturerEnrollment/Create

        [HttpGet]
        public ActionResult Create(FormCollection collection)
        {
            {
                var item = db.Courses.ToList();
                LecturerCourseViewModel m1 = new LecturerCourseViewModel();
                m1.AvailableCourses = item.Select(vm => new CheckBoxItem()
                {
                    CourseId = vm.CourseId,
                    CourseName = vm.CourseName,
                    IsChecked = false

                }).ToList();

                return View(m1);
            }
        }

        [HttpPost]
        public ActionResult Create(LecturerCourseViewModel LCVM,Lecturer lecturers,Course course )
        {
            List<LecturerCourse> cor = new List<LecturerCourse>();
            //int lecturerid =lecturers.LecturerId;
            //foreach (var item in LCVM.AvailableCourses)
            //{
            //    //if (item.IsChecked == true)
            //    //{
            //    //    db.Lecturers.AddObject(new Lecturer() { LecturerId = lecturerid, Course = item.CourseId });
            //    //}


            //}

            foreach (var item in LCVM.AvailableCourses)
            {
                foreach (var ite in cor)
                {
                    //db.Lecturers.AddObject(item);
                    db.SaveChanges();
                }
            }

            return View();
        } 
        
        //
        // GET: /LecturerEnrollment/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /LecturerEnrollment/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /LecturerEnrollment/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /LecturerEnrollment/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
