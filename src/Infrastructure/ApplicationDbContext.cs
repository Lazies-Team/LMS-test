using Domain.Entities.Courses;
using Domain.Entities.Homeworks;
using Domain.Entities.Lessons;
using Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
            => Database.Migrate();

        public DbSet<User> Users { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<HomeworkFile> HomeworkFiles { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
    }
}
