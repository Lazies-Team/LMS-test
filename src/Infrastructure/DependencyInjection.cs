﻿using Application.Abstractions.Users;
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
                .UseSqlite("Data Source =LMS.DB"));

            services.AddScoped<IUserRepository, IUserRepository>();

            return services;
        }
    }
}
