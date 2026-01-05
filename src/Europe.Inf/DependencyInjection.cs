using Europe.Domain.Entities;
using Europe.Inf.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Europe.Inf
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services ,IConfiguration configuration,string EnviromentName)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer("europeDB"));

            services.AddIdentity<User, IdentityRole<Guid>>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
                options.User.RequireUniqueEmail = true;
            })
            .AddEntityFrameworkStores<AppDbContext>() 
            .AddDefaultTokenProviders();

            return services;
        }
    }
}
            