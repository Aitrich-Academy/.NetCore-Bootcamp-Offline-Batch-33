using TravelsDb.Models;

namespace TravelsDb.Interfaces
{
    public interface ITourRepository
    {
        public Task<List<Tour>> GetAllAsync();
        public Task<Tour?> GetAllByIdAsync(int id);
        public Task AddAsync(Tour tour);
        public Task UpdateAsync(Tour tour);
        public Task DeleteAsync(int id);
        public Task SaveAsync();
    }
}
