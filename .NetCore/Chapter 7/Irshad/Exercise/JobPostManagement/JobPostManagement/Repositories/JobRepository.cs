using JobPostManagement.Data;
using JobPostManagement.Interfaces.Repositories;
using JobPostManagement.Models;
using Microsoft.EntityFrameworkCore;


namespace JobPostManagement.Repositories
{
    public class JobRepository : IJobRepository
    {
        public readonly AppDbContext context;

        public JobRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Job>> GetAllAsync()
        {
            return await context.Jobs.ToListAsync();
        }

        public async Task<Job?> GetByIdAsync(int id)
        {
            return await context.Jobs.FindAsync(id);
        }

        public async Task CreateAsync(Job job)
        {
            context.Jobs.Add(job);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Job job)
        {
            context.Jobs.Update(job);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var job = await context.Jobs.FindAsync(id);
            if (job != null)
            {
                context.Jobs.Remove(job);
                await context.SaveChangesAsync();
            }
        }

    }
}
