using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversitySystem.Models.ViewModel
{
    public class StudentCourseViewModel
    {
        public int StudentId { get; set; }

        public string StudentName { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public int CourseId { get; set; }

        public string CourseName { get; set; }

        public List<CheckBoxItem> AvailableCourses {get;set;}

    }
}