using JobPostManagement.Data;
using JobPostManagement.Interfaces;
using JobPostManagement.Services;
using Microsoft.EntityFrameworkCore;

using JobPostManagement.Interfaces.Repositories;
using JobPostManagement.Repositories;

namespace JobPostManagement.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServiceExtensions(this IServiceCollection builder, IConfiguration config)
        {
            // ✅ Add DbContext
            builder.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            builder.AddScoped<IUserService, UserService>();
            builder.AddScoped<IJobService, JobService>();
            builder.AddScoped<IJobApplicationService, ApplicationService>();

            builder.AddScoped<IUserRepository, UserRepository>();
            builder.AddScoped<IJobApplicationRepository, JobApplicationRepository>();
            builder.AddScoped<IJobRepository, JobRepository>();


            builder.AddAutoMapper(typeof(Program).Assembly);

            return builder;
        }
    }
}


