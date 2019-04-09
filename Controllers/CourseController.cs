using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversitySystem.Models;
using System.Data;

namespace UniversitySystem.Controllers
{
    public class CourseController : Controller
    {
        
        UniversitySystemContextDb db = new UniversitySystemContextDb();

        public ActionResult CourseAssign(Course course, Lecturer lecturer ,LecturerCourse lc)
        {
            //var item = db.Courses.ToList();
            List<LecturerCourse> len = new List<LecturerCourse>();
           
            
            {
                course.CourseId = lc.CourseId;
                course.CourseName = lc.CourseName;
                lecturer.LecturerId = lc.LecturerId;
                lecturer.LecturerName = lc.LecturerName;
            }
           

            int coursid = course.CourseId;
            foreach (var item in course.Assign)
            {
                len.Add(new LecturerCourse() { CourseId = coursid, LecturerName = item.LecturerName, LecturerId = item.LecturerId });
                
            }

            return View(len);
            
        }

        public ActionResult Index()
        {
            return View(db.Courses.ToList());
        }


        //
        // GET: /Course/Details/5

        public ActionResult Details(int id)
        {

            using (UniversitySystemContextDb db = new UniversitySystemContextDb())
            {
                return View(db.Courses.Where(c => c.CourseId == id).FirstOrDefault());
            }
        }

        //public ActionResult AssignLecture(int id = 0)
        //{
        //}
        
        // GET: /Course/Create

        public ActionResult Create()
        {

            Course assignLecturer = new Course();
            using (UniversitySystemContextDb db = new UniversitySystemContextDb())
            {
                assignLecturer.Assign = db.Lecturers.ToList<Lecturer>();
            }
            return View(assignLecturer);


            
        } 

        //
        // POST: /Course/Create

        [HttpPost]
        public ActionResult Create(Course newCourse )
        {
            
            if (ModelState.IsValid)
            {
                
                db.AddToCourses(newCourse);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(newCourse);
            }
        }
        
        //
        // GET: /Course/Edit/5
 
        public ActionResult Edit(int id)
        {
            Course course = db.Courses.Single(c=>c.CourseId == id);
            if (course == null)
            {
                return View("NotFound");
            }

            return View(course);
        }

        //
        // POST: /Course/Edit/5

        [HttpPost]
        public ActionResult Edit(int id,Course course)
        {
            if (ModelState.IsValid)
            {
                db.Courses.Attach(course);
                db.ObjectStateManager.ChangeObjectState(course, EntityState.Modified);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        //
        // GET: /Course/Delete/5
 
        public ActionResult Delete(int id )
        {
            using (UniversitySystemContextDb db = new UniversitySystemContextDb())
            {
                return View(db.Courses.Where(c=>c.CourseId == id).FirstOrDefault());
            }
        }

        //
        // POST: /Course/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (UniversitySystemContextDb db = new UniversitySystemContextDb())
                {
                    Course course = db.Courses.Where(c=>c.CourseId == id).FirstOrDefault();
                    db.Courses.DeleteObject(course);
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
