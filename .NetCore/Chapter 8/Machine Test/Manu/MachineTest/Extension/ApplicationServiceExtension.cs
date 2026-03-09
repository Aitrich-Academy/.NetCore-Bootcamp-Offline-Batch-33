using MachineTest.Model;
using MachineTest.Repository;
using MachineTest.Service;
using Microsoft.EntityFrameworkCore;

namespace MachineTest.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
            (this  IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped<TaskRepository>();
            services.AddScoped<TaskServices>();


                return services;
        }
    }
}
