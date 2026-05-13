using Domain.Data;
using Domain.Models;
using Domain.Services.Job_Seeker.Jobs.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services.Job_Seeker.Jobs
{
    public class JobRepository : IJobRepository
    {
        private readonly AppDbContext _context;

        public JobRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Job>> GetAllAsync()
        {
            return await _context.Jobs
                .Include(j => j.Company)
                .Include(j => j.Location)
                .ToListAsync();
        }

        public async Task<List<Job>> SearchAsync(string? keyword)
        {
            var query = _context.Jobs
                .Include(j => j.Company)
                .Include(j => j.Location)
                .AsQueryable();

            if(string.IsNullOrEmpty(keyword))
            {
                query = query.Where(j => j.Title.Contains(keyword));
            }

            return await query.ToListAsync();
        }

    }
}
