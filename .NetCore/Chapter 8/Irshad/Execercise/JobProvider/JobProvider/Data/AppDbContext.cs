using JobProvider.Model;
using Microsoft.EntityFrameworkCore;

namespace JobProvider.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Job> Jobs { get; set; }
    }
}
