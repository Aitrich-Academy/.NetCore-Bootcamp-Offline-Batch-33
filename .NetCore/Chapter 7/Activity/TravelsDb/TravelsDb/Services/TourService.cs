using TravelsDb.Models;
using TravelsDb.Interfaces;

namespace TravelsDb.Services
{
    public class TourService : ITourService
    {
        private readonly ITourRepository _tourRepository;

        public TourService(ITourRepository tourRepository)
        {
            _tourRepository = tourRepository;
        }

        public async Task<List<Tour>> GetAllAsync()
        {
            return await _tourRepository.GetAllAsync();
        }

        public async Task<Tour?> GetAllByIdAsync(int id)
        {
            return await _tourRepository.GetAllByIdAsync(id);
        }

        public async Task AddAsync(Tour tour)
        {
            await _tourRepository.AddAsync(tour);
            await _tourRepository.SaveAsync();
        }

        public async Task UpdateAsync(Tour tour)
        {
            await _tourRepository.UpdateAsync(tour);
            await _tourRepository.SaveAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _tourRepository.DeleteAsync(id);
            await _tourRepository.SaveAsync();
        }
    }
}
