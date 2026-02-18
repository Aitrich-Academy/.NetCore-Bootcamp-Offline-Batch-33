using JobPostManagement.Models;

namespace JobPostManagement.Interfaces.Repositories
{
    public interface IJobApplicationRepository
    {
        public Task<bool> AlreadyAppliedAsync(int jobId, string userId);
        public Task ApplyToJobAsync(int jobId, string userId);
        public Task<List<JobApplication>> GetUserApplicationsAsync(string userId);
    }
}
