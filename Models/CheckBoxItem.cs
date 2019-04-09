using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversitySystem.Models
{
    public class CheckBoxItem
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public bool IsChecked { get; set; }
    }
}