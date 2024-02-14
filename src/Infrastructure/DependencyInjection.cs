using Application.Abstractions.Courses;
using Application.Abstractions.Users;
using Infrastructure.Repositories.Courses;
using Infrastructure.Repositories.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseLazyLoadingProxies() //Lazy loading
                .UseSqlServer(configuration.GetConnectionString("SqlServer")));

            //user
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<ISpecialtyRepository, SpecialtyRepository>();

            return services;
        }
    }
}
