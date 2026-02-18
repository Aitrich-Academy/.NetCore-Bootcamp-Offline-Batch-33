using JobPostManagement.Models;

namespace JobPostManagement.Interfaces.Repositories
{
    public interface IJobRepository
    {
        public Task<List<Job>> GetAllAsync();
        public Task<Job> GetByIdAsync(int id);
        public Task CreateAsync(Job job);
        public Task UpdateAsync(Job job);
        public Task DeleteAsync(int id);
    }
}
