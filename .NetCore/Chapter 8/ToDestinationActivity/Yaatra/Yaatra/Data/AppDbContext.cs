using Microsoft.EntityFrameworkCore;
using Yaatra.Models;

namespace Yaatra.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Consultant> Consultants { get; set; }
    }
}
