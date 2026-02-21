using LibraryManagementSystem.Interface;
using LibraryManagementSystem.Model;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Service;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            // Register DbContext
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // Register Repository
            services.AddScoped<IBookRepository, BookRepository>();

            // Register Service
            services.AddScoped<BookService>();

            return services;
        }
    }
}