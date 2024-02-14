using Application.Halpers.Hasher;
using Application.Services.Contracts.Courses;
using Application.Services.Contracts.Users;
using Application.Services.Courses;
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

            //courses
            services.AddScoped<ICourseService, CourseService>();

            return services;
        }
    }
}
