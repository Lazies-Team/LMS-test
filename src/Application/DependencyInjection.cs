using Application.Halpers.Hasher;
using Application.Services.Contracts.Users;
using Application.Services.Users;
using Domain.Entities.Users;
using Mapster;
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

            //mapster config
            TypeAdapterConfig<User, User>
                .NewConfig()
                .IgnoreNullValues(true);

            return services;
        }
    }
}
