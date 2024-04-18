﻿using Microsoft.EntityFrameworkCore;
using PDP_Examp.Entities;

namespace PDP_Examp.Data
{
    public class UniversityDbContext : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<CourseAssignment> CourseAssignments { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Course> Courses { get; set; }

        public UniversityDbContext(DbContextOptions options)
            : base(options)
        {

        }
    }
}
