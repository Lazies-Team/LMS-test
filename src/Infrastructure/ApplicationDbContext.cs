using Domain.Entities;
using Domain.Entities.Courses;
using Domain.Entities.Homeworks;
using Domain.Entities.Lessons;
using Domain.Entities.Tasks;
using Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
            => Database.Migrate();

        //users
        public DbSet<User> Users { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Admin> Admins { get; set; }

        //course
        public DbSet<Course> Courses { get; set; }
        public DbSet<Speciality> Specialities { get; set; }

        //homework
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<HomeworkFile> HomeworkFiles { get; set; }

        //lesson
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Video> Videos { get; set; }

        //tasks
        public DbSet<Grade> Grades { get; set; }
        public DbSet<TaskResult> TaskResults { get; set; }
        public DbSet<TaskResultFile> TaskResultFiles { get; set; }

        //relationtables
        public DbSet<CourseStudent> CourseStudents { get; set; }
        public DbSet<CourseTeacher> CourseTeachers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
