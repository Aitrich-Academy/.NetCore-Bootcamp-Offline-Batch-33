using JobProvider.Data;
using JobProvider.Interface;
using JobProvider.Model;
using Microsoft.EntityFrameworkCore;

namespace JobProvider.Repository
{
    public class JobRepository : IJobRepository
    {
        private readonly AppDbContext context;
        public JobRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Job>> GetJobsAsync()
        {
            return await context.Jobs.ToListAsync();
        }
        public async Task<Job?> GetJobByIdAsync(int id)
        {
            return await context.Jobs.SingleOrDefaultAsync(e => e.Id == id);
        }
        public async Task AddJobAsync(Job job)
        {
            await context.Jobs.AddAsync(job);
            context.SaveChanges();
        }
        public async Task UpdateJobAsync(Job job)
        {
            context.Jobs.Update(job);
            context.SaveChanges();
        }
        public async Task DeleteJobAsync(int id)
        {
            var job = await GetJobByIdAsync(id);
            if (job != null)
            {
                context.Jobs.Remove(job);
                await context.SaveChangesAsync();
            }

        }
    }
}
