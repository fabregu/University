using Microsoft.EntityFrameworkCore;
using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend.DataAccess
{
    public class UniversityDBContext: DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        //public DbSet<Course> Courses { get; set; }
        //public DbSet<Enrollment> Enrollments { get; set; }
        //public DbSet<Instructor> Instructors { get; set; }
        //public DbSet<Department> Departments { get; set; }
        //public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        //public DbSet<EnrollmentType> EnrollmentTypes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the primary keys and relationships here if needed
            base.OnModelCreating(modelBuilder);
        }
    }
}
