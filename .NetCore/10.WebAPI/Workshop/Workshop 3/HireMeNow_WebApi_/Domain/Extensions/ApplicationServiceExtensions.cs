using Domain;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions
{
    public static class ApplicationServiceExtensions
    {

        public static IServiceCollection AddApplicationServices1(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DbHireMeNowWebApiContext>(options =>
               options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
            );
            return services;
        }
    }
}
