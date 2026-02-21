using JobPostManagement.Interfaces;
using JobPostManagement.Interfaces.Repositories;
using JobPostManagement.Models;

namespace JobPostManagement.Services
{
    public class ApplicationService : IJobApplicationService
    {
        private readonly IJobApplicationRepository jobApplicationRepository;

        public ApplicationService(IJobApplicationRepository jobApplicationRepository)
        {
            this.jobApplicationRepository = jobApplicationRepository;
        }

        public async Task<bool> AlreadyAppliedAsync(int jobId, string userId)
        {
            return await jobApplicationRepository.AlreadyAppliedAsync(jobId, userId);
        }

        public async Task ApplyToJobAsync(int jobId, string userId)
        {
            
            await jobApplicationRepository.ApplyToJobAsync(jobId, userId);
        }

        public async Task<List<JobApplication>> GetUserApplicationsAsync(string userId)
        {
            return await jobApplicationRepository.GetUserApplicationsAsync(userId);
        }
    }
}
