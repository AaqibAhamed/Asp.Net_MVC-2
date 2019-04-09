using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversitySystem.Models;
using UniversitySystem.Models.ViewModel;
using System.Data;

namespace UniversitySystem.Controllers
{
    public class StudentEnrollmentController : Controller
    {
        //
        // GET: /StudentEnrollment/
        UniversitySystemContextDb db = new UniversitySystemContextDb();


        public ActionResult Index(/*StudentCourseViewModel scvm, Student std, StudentsEnrollment enroll*/)
        {

            return View(db.Students.ToList());

        }

        //public ActionResult Enroll(Student students  ,StudentCourseViewModel SCVM ,StudentsEnrollment enroll,Course course)
        //{
        //    List<StudentsEnrollment> ste = new List<StudentsEnrollment>();
        //   // students.StudentName = enroll.StudentName;
        //    students.StudentId = enroll.StudentId;
        //    course.CourseId = enroll.CourseId;
        //    //course.CourseName = enroll.CourseName;

        //    db.StudentsEnrollments.AddObject(enroll);
        //    db.SaveChanges();

        //    return View(db.StudentsEnrollments.ToList());

        //}
        
        // GET: /StudentEnrollment/Details/5

        public ActionResult Details(int id)
        {
            StudentCourseViewModel SCVM = new StudentCourseViewModel();

            //var enroll =  db.Students.Join(s=>s.StudentsEnrollment).ThenInclude(c=>c.Course).AsNoTracking().SingleOrDefault(e => e.StudentId == id);

            Student enroll = db.Students.SingleOrDefault(e => e.StudentId == id);


            var item = db.Courses.ToList();
            StudentCourseViewModel m1 = new StudentCourseViewModel();
            m1.AvailableCourses = item.Select(vm => new CheckBoxItem()

            {
                CourseId = vm.CourseId,
                CourseName = vm.CourseName,
                IsChecked = vm.StudentsEnrollments.Any(x => x.StudentId == enroll.StudentId) ? true : false


            }).ToList();

            SCVM.StudentName = enroll.StudentName;
            SCVM.Email = enroll.Email;
            SCVM.Address = enroll.Address;
            SCVM.AvailableCourses = m1.AvailableCourses;


            return View(SCVM);
        }

       
        [HttpGet]
        public ActionResult Create(FormCollection collection)
        {
            var item = db.Courses.ToList();
            StudentCourseViewModel m1 = new StudentCourseViewModel();
            m1.AvailableCourses = item.Select(vm => new CheckBoxItem()
            {
                CourseId = vm.CourseId,
                CourseName = vm.CourseName,
                IsChecked = false

            }).ToList();

            return View(m1);
        }

        [HttpPost]
        public ActionResult Create(StudentCourseViewModel SCVM,  Student students  ,StudentsEnrollment enroll)
        {
            List<StudentsEnrollment> ste = new List<StudentsEnrollment>();
            students.StudentName = SCVM.StudentName;
            students.Address = SCVM.Address;
            students.Email = SCVM.Email;
            students.StudentId = SCVM.StudentId;

            db.Students.AddObject(students);
            db.SaveChanges();

            
            //enroll.StudentId = SCVM.StudentId;
            //enroll.CourseId = SCVM.CourseId;
            ////enroll.CourseName = SCVM.CourseName;
            //db.StudentsEnrollments.AddObject(enroll);
            
           // enroll.StudentName = SCVM.StudentName;
            
            //db.StudentsEnrollments.AddObject(enroll);
            //db.SaveChanges();
            
            
            
            int studentid =students.StudentId;

            foreach (var item in SCVM.AvailableCourses)
            {
                if (item.IsChecked == true)
                {
                    ste.Add(new StudentsEnrollment()
                    {StudentId =studentid,CourseId =item.CourseId });
                    //db.StudentsEnrollments.AddObject(new StudentsEnrollment()
                    //{StudentId=studentid,CourseId=item.CourseId,CourseName =item.CourseName });



                    //ste.Add(new StudentCourse() { StudentId = studentid, CourseId = item.CourseId });
                    //db.StudentsEnrollments.AddObject(new StudentsEnrollment() { StudentId = studentid, CourseId = item.CourseId });
                }

            }

            foreach(var item in ste)
            {
                db.StudentsEnrollments.AddObject(item);
                
            }
            db.SaveChanges();
            return RedirectToAction("Index");
           
            //return View();

            
        }
            //using (UniversitySystemContextDb db = new UniversitySystemContextDb())
            //{
            //    var res = db.Courses.Where(c => c.CourseId == id).FirstOrDefault();

            //    return View(db.Courses.Where(c => c.CourseId == id).FirstOrDefault());

            //}
            //db.Courses.AddObject(assign);
            //return View(assign);
        

        //
        // GET: /StudentEnrollment/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            
            StudentCourseViewModel SCVM = new StudentCourseViewModel();
            
             //var enroll =  db.Students.Include(s=>s.StudentCourse).ThenInclude(c=>c.Course).AsNoTracking().SingleOrDefault(e => e.StudentId == id);
             
           Student enroll = db.Students.SingleOrDefault(e => e.StudentId == id);

           
            var item = db.Courses.ToList();
            StudentCourseViewModel m1 = new StudentCourseViewModel();
            m1.AvailableCourses = item.Select(vm => new CheckBoxItem()
            
            {
                CourseId = vm.CourseId,
                CourseName = vm.CourseName,
                IsChecked = vm.StudentsEnrollments.Any(x => x.StudentId ==  enroll.StudentId ) ? true : false


            }).ToList();

            SCVM.StudentName = enroll.StudentName;
            SCVM.Email = enroll.Email;
            SCVM.Address = enroll.Address;
            SCVM.AvailableCourses = m1.AvailableCourses;


            return View(SCVM);
            
        }

        //
        // POST: /StudentEnrollment/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, StudentCourseViewModel SCVM, Student students ,StudentsEnrollment enroll)
        {
            List<StudentsEnrollment> ste = new List<StudentsEnrollment>();
            students.StudentName = SCVM.StudentName;
            students.Address = SCVM.Address;
            students.Email = SCVM.Email;
            students.StudentId = SCVM.StudentId;

            db.Students.Attach(students); //check attach wrk or not 
            db.ObjectStateManager.ChangeObjectState(students, EntityState.Modified);
            db.SaveChanges();
            int studentid = students.StudentId;

            foreach (var item in SCVM.AvailableCourses)
            {
                if (item.IsChecked == true)
                {
                    ste.Add(new StudentsEnrollment() { StudentId = studentid, CourseId = item.CourseId });
                   
                }

            }

            var dbtable = db.StudentsEnrollments.Where(a => a.StudentId == studentid).ToList();
            var result = dbtable.Except(ste).ToList();

            foreach (var item in result)
            {
                db.StudentsEnrollments.DeleteObject(item);
                db.SaveChanges();
            }

            var getcourseid =db.StudentsEnrollments.Where(a => a.StudentId == studentid).ToList();
            foreach (var item in ste)
            {
                if (!getcourseid.Contains(item)) ;
                {
                    db.StudentsEnrollments.AddObject(item);
                    db.SaveChanges();
                }
            }
            return RedirectToAction("Index");

            
        }

        //
        // GET: /StudentEnrollment/Delete/5

        public ActionResult Delete(int id)
        {

            StudentCourseViewModel SCVM = new StudentCourseViewModel();

            //var enroll =  db.Students.Join(s=>s.StudentsEnrollment).ThenInclude(c=>c.Course).AsNoTracking().SingleOrDefault(e => e.StudentId == id);

            Student enroll = db.Students.SingleOrDefault(e => e.StudentId == id);
            //StudentsEnrollment enroll = db.StudentsEnrollments.SingleOrDefault(e => e.EnrollmentId == id);

            var item = db.Courses.ToList();
            StudentCourseViewModel m1 = new StudentCourseViewModel();
            m1.AvailableCourses = item.Select(vm => new CheckBoxItem()

            {
                CourseId = vm.CourseId,
                CourseName = vm.CourseName,
                IsChecked = vm.StudentsEnrollments.Any(x => x.StudentId == enroll.StudentId) ? true : false


            }).ToList();

            //SCVM.StudentName = enroll.StudentName;
            SCVM.Email = enroll.Email;
            SCVM.Address = enroll.Address;
            SCVM.AvailableCourses = m1.AvailableCourses;


            return View(SCVM);
        }

        //
        // POST: /StudentEnrollment/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            
            try
            {
                using (UniversitySystemContextDb db = new UniversitySystemContextDb())
                {
                    //Student enroll = db.Students.Where(e => e.StudentId == id).FirstOrDefault();
                    StudentsEnrollment enroll = db.StudentsEnrollments.SingleOrDefault(e => e.EnrollmentId == id);
                    db.StudentsEnrollments.DeleteObject(enroll);
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
