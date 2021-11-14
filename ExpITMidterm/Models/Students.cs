using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpITMidterm.Models
{
    public class Students
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CourseId { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public int CourseStatus { get; set; }
        public string Grade { get; set; }
    }
}