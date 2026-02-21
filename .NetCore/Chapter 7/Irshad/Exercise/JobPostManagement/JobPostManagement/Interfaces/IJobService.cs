using JobPostManagement.Models;

namespace JobPostManagement.Interfaces
{
    public interface IJobService
    {
        public Task<List<Job>> GetAllJobsAsync();
        public Task<Job> GetJobByIdAsync(int id);
        public Task CreateJobAsync(Job job);
        public Task UpdateJobAsync(Job job);
        public Task DeleteJobAsync(int id);
    }
}
