using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversitySystem.Models
{
    public class LecturerCourse
    {
        public int CourseId { get; set; }

        public string CourseName { get; set; }


        public int LecturerId { get; set; }

        public string LecturerName { get; set; }

    }
}