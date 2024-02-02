using API.Models.Entities.Concrete;
using API.Models.Entities.SqlViews;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<InstructorAddress> InstructorAddresses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
        public DbSet<Departmant> Departmants { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<V_StudentTable> V_StudentTable { get; set; }
        public DbSet<V_InstructorTable> V_InstructorTable { get; set; }
        public DbSet<V_DepartmantTable> V_DepartmantTable { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<V_StudentTable>().ToView("V_StudentTable");
            modelBuilder.Entity<V_InstructorTable>().ToView("V_InstructorTable");
            modelBuilder.Entity<V_DepartmantTable>().ToView("V_DepartmantTable");
            base.OnModelCreating(modelBuilder);
        }
    }
}
