using Microsoft.EntityFrameworkCore;
using TourManagement.Data;
using TourManagement.Interface;
using TourManagement.Model;

namespace TourManagement.Repository
{
    public class DestinationRepository : IDestinationRepository
    {
        private readonly ApplicationDbContext _context;

        public DestinationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Destination>> GetAllDestinationAsync()
        {
            return await _context.Destination.ToListAsync();
        }

        public async Task<Destination?> GetDestinationByIdAsync(int id)
        {
            return await _context.Destination.FindAsync(id);
        }

        public async Task AddDestinationAsync(Destination destination)
        {
            await _context.Destination.AddAsync(destination);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateDestinationAsync(Destination destination)
        {
            var existingDestination = await _context.Destination.FindAsync(destination.Id);

            if (existingDestination != null)
            {
                existingDestination.Title = destination.Title;
                existingDestination.Description = destination.Description;
                existingDestination.ImageUrl = destination.ImageUrl;

                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteDestinationAsync(Destination destination)
        {
            _context.Destination.Remove(destination);
            await _context.SaveChangesAsync();
        }
    }
}