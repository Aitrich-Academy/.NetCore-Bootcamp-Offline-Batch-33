using Domain.Models;

namespace Domain.Services.Job_Seeker.Jobs.Interfaces
{
    public interface IJobRepository
    {
        Task<List<Job>> GetAllAsync();
        Task<List<Job>> SearchAsync(string? keyword);
    }
}
