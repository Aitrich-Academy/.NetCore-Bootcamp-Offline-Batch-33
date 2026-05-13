using Domain.Services.Job_Seeker.Jobs.DTOs;

namespace Domain.Services.Job_Seeker.Jobs.Interfaces
{
    public interface IJobService
    {
        Task<List<GetJobsDto>> GetAllJobsAsync();
        Task<List<GetJobsDto>> SearchJobsAsync(string? keyword);
    }
}
