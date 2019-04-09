using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversitySystem.Models.ViewModel
{
    public class LecturerCourseViewModel
    {
        public int LecturerId { get; set; }

        public string LecturerName { get; set; }

        public string Address { get; set; }

       

        public List<CheckBoxItem> AvailableCourses { get; set; }
    }
}