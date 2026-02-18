using JobPostManagement.Models;

namespace JobPostManagement.Interfaces
{
    public interface IJobApplicationService
    {
        public Task<bool> AlreadyAppliedAsync(int jobId, string userId);
        public Task ApplyToJobAsync(int jobId, string userId);
        public Task<List<JobApplication>> GetUserApplicationsAsync(string userId);
    }

}
