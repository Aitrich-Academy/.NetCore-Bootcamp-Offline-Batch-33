using Microsoft.EntityFrameworkCore;
using TourManagement.Data;
using TourManagement.Interface;
using TourManagement.Repository;
using TourManagement.Service;

namespace TourManagement.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
        (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped<IDestinationRepository, DestinationRepository>();
            services.AddScoped<IDestinationService, DestinationService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAuthService, AuthService>();

            services.AddSingleton<UserSessionService>();

            services.AddAutoMapper(typeof(Program));

            return services;
        }
    }
}