using JobProvider.Interface;
using JobProvider.Model;

namespace JobProvider.Service
{
    public class JobService : IJobService
    {
        public readonly IJobRepository jobRepository;
        public JobService(IJobRepository jobRepository)
        {
            this.jobRepository = jobRepository;
        }

        public async Task<List<Job>> GetJobsAsync()
        {
            return await jobRepository.GetJobsAsync();
        }
        public async Task<Job?> GetJobByIdAsync(int id)
        {
            return await jobRepository.GetJobByIdAsync(id);
        }
        public async Task AddJobAsync(Job job)
        {
            await jobRepository.AddJobAsync(job);
        }
        public async Task UpdateJobAsync(Job job)
        {
            await jobRepository.UpdateJobAsync(job);
        }
        public async Task DeleteJobAsync(int id)
        {
            await jobRepository.DeleteJobAsync(id);
        }
    }
}
