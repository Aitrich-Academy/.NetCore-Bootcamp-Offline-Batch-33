using Domain.Data;
using Domain.Services.JobProvider;
using Domain.Services.JobProvider.Profile.Interface;
using Microsoft.EntityFrameworkCore;

namespace JOB_PORTAL_SYSTEM.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServiceExtension(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<ICompanyService, CompanyService>();

            services.AddAutoMapper(map => map.AddProfile(new UseProfileMapping()));

            return services;
        }
    }
}
