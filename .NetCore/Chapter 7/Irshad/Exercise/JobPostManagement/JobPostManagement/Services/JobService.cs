using JobPostManagement.Data;
using JobPostManagement.Interfaces;
using Microsoft.EntityFrameworkCore;
using JobPostManagement.Models;
using JobPostManagement.Interfaces.Repositories;

namespace JobPostManagement.Services
{
    public class JobService : IJobService
    {
        private readonly IJobRepository jobRepository;
        public JobService(IJobRepository jobRepository)
        {
            this.jobRepository = jobRepository;
        }

        public async Task<List<Job>> GetAllJobsAsync()
        {
            return await jobRepository.GetAllAsync();
        }

        public async Task<Job?> GetJobByIdAsync(int id)
        {
            return await jobRepository.GetByIdAsync(id);
        }

        public async Task CreateJobAsync(Job job)
        {
            await jobRepository.CreateAsync(job);

        }

        public async Task UpdateJobAsync(Job job)
        {
            await jobRepository.UpdateAsync(job);
        }

        public async Task DeleteJobAsync(int id)
        {
            await jobRepository.DeleteAsync(id);
        }
    }
}
