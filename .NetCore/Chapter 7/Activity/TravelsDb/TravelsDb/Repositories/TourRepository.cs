using Microsoft.EntityFrameworkCore;
using TravelsDb.Data;
using TravelsDb.Interfaces;
using TravelsDb.Models;

namespace TravelsDb.Repositories
{
    public class TourRepository : ITourRepository
    {
        private readonly AppDbContext _context;
        public TourRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Tour>> GetAllAsync()
        {
            return await _context.Tours
                .Include(t => t.Destination)
                .ToListAsync();
        }
        public async Task<Tour?> GetAllByIdAsync(int id)
        {
            return await _context.Tours
                .Include(t => t.Destination)
                .FirstOrDefaultAsync(t => t.Id == id);
        }
        public async Task AddAsync(Tour tour)
        {
            await _context.Tours.AddAsync(tour);
        }
        public async Task UpdateAsync(Tour tour)
        {
            _context.Tours.Update(tour);
        }
        public async Task DeleteAsync(int id)
        {
            var tour = await GetAllByIdAsync(id);
            if (tour != null)
            {
                _context.Tours.Remove(tour);
            }
        }
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
