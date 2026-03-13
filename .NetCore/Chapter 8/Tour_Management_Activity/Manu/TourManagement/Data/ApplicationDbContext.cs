using Microsoft.EntityFrameworkCore;
using TourManagement.Model;

namespace TourManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Destination> Destination { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
