using ExpITMidterm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExpITMidterm.ViewModels
{
    public class StudentViewModel
    {
        public Students Student { get; set; }
        public List<Courses> CourseList { get; set; }
        public List<CourseStatus> CourseStatuses { get; set; }
    }
}