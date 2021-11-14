using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExpITMidterm.Models
{
    public class StudentContext : DbContext
    {


        public StudentContext() : base("name=StudentContext")
        {


        }

        public DbSet<Students> Students { get; set; }

        public DbSet<Courses> Courses { get; set; }


    }
}
    
