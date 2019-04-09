using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace UniversitySystem.Models
{
    public partial  class Course
    {
        
        
        //public int CourseId { get; set; }

        //public string CourseName { get; set; }

        //public int CourseCredit { get; set; }

        //public int LecturerId { get; set; }
        
        public List<StudentsEnrollment> Enroll { get; set; }

        //[NotMapped]
        public List<Lecturer> Assign { get; set; }
    }
}