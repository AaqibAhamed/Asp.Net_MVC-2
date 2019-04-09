using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace UniversitySystem.Models
{
    //[MetadataType(typeof(StudentMetadata))]
    public  partial class Student
    {
        //public int StudentId { get; set; }
        //[Display(Name = "Student Name")]
        //public string StudentName { get; set; }

        //public string Address { get; set; }

        //public string Email { get; set; }

        public List<StudentsEnrollment> Enroll { get; set; }


    }

    //public class StudentMetadata
    //{

    //    [DisplayName("Student Name")]

    //    public string StudentName { get; set; }


    //}
}