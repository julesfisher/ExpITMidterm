﻿namespace ExpITMidterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentData : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Courses",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            CourseName = c.String(),
            //            CourseDescription = c.String(),
            //            TutorName = c.String(),
            //            CourseRating = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.Students",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            FirstName = c.String(),
            //            LastName = c.String(),
            //            CourseId = c.Int(nullable: false),
            //            EnrollmentDate = c.DateTime(nullable: false),
            //            CourseStatus = c.Int(nullable: false),
            //            Grade = c.String(),
            //        })
            //    .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
           // DropTable("dbo.Students");
           // DropTable("dbo.Courses");
        }
    }
}
