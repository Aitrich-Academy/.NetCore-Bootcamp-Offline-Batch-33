using JobPostManagement.Data;
using JobPostManagement.Interfaces.Repositories;
using JobPostManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace JobPostManagement.Repositories
{
    public class JobApplicationRepository : IJobApplicationRepository
    {
        private readonly AppDbContext context;

        public JobApplicationRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<bool> AlreadyAppliedAsync(int jobId, string userId)
        {
            return await context.JobApplications
                .AnyAsync(ja => ja.JobId == jobId && ja.UserId == userId);
        }

        public async Task ApplyToJobAsync(int jobId, string userId)
        {
            var application = new JobApplication
            {
                JobId = jobId,
                UserId = userId,
                AppliedAt = DateTime.UtcNow
            };

            await context.JobApplications.AddAsync(application);
            await context.SaveChangesAsync();
        }

        public async Task<List<JobApplication>> GetUserApplicationsAsync(string userId)
        {
            return await context.JobApplications
                .Include(ja => ja.Job)
                .Where(ja => ja.UserId == userId)
                .ToListAsync();
        }
    }
}
