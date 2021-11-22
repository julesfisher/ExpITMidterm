using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExpITMidterm.Models
{
    public class Students
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [_18YearsOrOlder]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Course ID")]
        [Required]
        public int CourseId { get; set; }

        [Display(Name = "Enrollment Date")]
        [Required]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Course Status")]
        [Required]
        public int CourseStatus { get; set; }

        [Display(Name = "Grade")]
        [Required]
        [Range(1,10)]
        public string Grade { get; set; }
    }
}