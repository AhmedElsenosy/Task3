using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Configuration;

namespace Task3
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> students { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Enrollment> enrollments { get; set; }
        public DbSet<Grade> grades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("server = DESKTOP-K5KPDDO ; database = Task3 ; trustservercertificate = true ; Integrated Security = SSPI");


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TeacherConfig).Assembly);
        }
    }
}
