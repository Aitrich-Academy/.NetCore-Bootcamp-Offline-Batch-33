using JobProviderApp.Interface;
using JobProviderApp.Model;
using Microsoft.EntityFrameworkCore;

namespace JobProviderApp.Repository
{
    public class JobProviderRepository : IJobProviderRepository
    {
        private readonly IDbContextFactory<JobProviderAppDbContext> contextFactory;

        public JobProviderRepository(IDbContextFactory<JobProviderAppDbContext> contextFactory)
        {
            this.contextFactory = contextFactory;
        }

        public async Task<JobProvider> GetByEmailAsync(string email)
        {
            using var context = contextFactory.CreateDbContext();
            return await context.JobProviders.FirstOrDefaultAsync(jp => jp.Email == email);
        }

        public async Task AddAsync(JobProvider jobProvider)
        {
            using var context = contextFactory.CreateDbContext();

            context.JobProviders.Add(jobProvider);
            await context.SaveChangesAsync();
        }
    }

}