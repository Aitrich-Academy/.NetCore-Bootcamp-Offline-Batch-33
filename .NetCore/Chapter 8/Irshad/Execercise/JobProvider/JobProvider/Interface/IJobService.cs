using JobProvider.Model;

namespace JobProvider.Interface
{
    public interface IJobService
    {
        public Task<List<Job>> GetJobsAsync();
        public Task<Job?> GetJobByIdAsync(int id);
        public Task AddJobAsync(Job job);
        public Task UpdateJobAsync(Job job);
        public Task DeleteJobAsync(int id);
    }
}
