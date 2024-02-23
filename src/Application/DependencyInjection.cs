using Application.Halpers.Hasher;
using Application.Services.Contracts.Courses;
using Application.Services.Contracts.Homeworks;
using Application.Services.Contracts.Lessons;
using Application.Services.Contracts.Users;
using Application.Services.Courses;
using Application.Services.Homeworks;
using Application.Services.Lessons;
using Application.Services.Users;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IPasswordHasher, PasswordHasher>();

            //users
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IAdminService, AdminService>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<ITeacherService, TeacherService>();

            //courses
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<ISpecialityService, SpecialityService>();

            //homeworks
            services.AddScoped<IHomeworkService, HomeworkService>();
            services.AddScoped<IHomeworkFileService, HomeworkFileService>();

            //Lessons
            services.AddScoped<ILessonService, LessonService>();
            services.AddScoped<IAttendanceService, AttendanceService>();
          
            return services;
        }
    }
}
