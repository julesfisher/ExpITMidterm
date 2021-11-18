using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExpITMidterm.Models
{
    public class Courses
    {

        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Course Name")]
        public string CourseName { get; set; }

        [Display(Name = "Course Description")]
        public string CourseDescription { get; set; }

        [Display(Name = "Tutor Name")]
        public string TutorName { get; set; }

        [Display(Name = "Course Rating")]
        public int CourseRating { get; set; }
    }
}