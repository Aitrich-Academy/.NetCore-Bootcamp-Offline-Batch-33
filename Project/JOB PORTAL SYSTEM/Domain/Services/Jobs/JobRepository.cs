using Domain.Data;
using Domain.Models;
using Domain.Services.Jobs.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services.Jobs
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
        public async Task<Job> AddJobAsync(Job job)
        {
            try
            {
                var company = await _context.Companies.FindAsync(job.CompanyId);
                if (company == null)
                {
                    throw new Exception("Company not found");
                }
                var category = await _context.JobCategories.FindAsync(job.CategoryId);
                if (category == null)
                {
                    throw new Exception("Category not found");
                }
                var location = await _context.Locations.FindAsync(job.LocationId);
                if (location == null)
                {
                    throw new Exception("Location not found");
                }
                _context.Jobs.Add(job);
                await _context.SaveChangesAsync();
                return job;

            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding job: {ex.Message}");
            }
        }

        public async Task<Job?> GetJobByIdAsync(Guid jobId)
        {
            try
            {
                var job = await _context.Jobs.FindAsync(jobId);
                if (job == null)
                {
                    throw new Exception("Job not found");
                }

                return await _context.Jobs
                    .Include(j => j.Company)
                    .Include(j => j.Category)
                    .Include(j => j.Location)
                    .FirstOrDefaultAsync(j => j.Id == jobId);

            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving job: {ex.Message}");
            }

        }

        public async Task<IEnumerable<Job>> GetAllJobsAsync()
        {
            try
            {
                if (!await _context.Jobs.AnyAsync())
                {
                    return new List<Job>();
                }
                return await _context.Jobs
                    .Include(j => j.Company)
                    .Include(j => j.Category)
                    .Include(j => j.Location)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving jobs: {ex.Message}");
            }
        }

        public async Task<Job> UpdateJobAsync(Job job)
        {
            try
            {
                var existingJob = await _context.Jobs.FindAsync(job.Id);
                if (existingJob == null)
                {
                    throw new Exception("Job not found");
                }
                var company = await _context.Companies.FindAsync(job.CompanyId);
                if (company == null)
                {
                    throw new Exception("Company not found");
                }
                var category = await _context.JobCategories.FindAsync(job.CategoryId);
                if (category == null)
                {
                    throw new Exception("Category not found");
                }
                var location = await _context.Locations.FindAsync(job.LocationId);
                if (location == null)
                {
                    throw new Exception("Location not found");
                }
                _context.Jobs.Update(job);
                await _context.SaveChangesAsync();
                return job;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating job: {ex.Message}");
            }
        }

        public async Task<bool> DeleteJobAsync(Guid jobId)
        {
            try
            {
                var job = await _context.Jobs.FindAsync(jobId);
                if (job == null)
                {
                    throw new Exception("Job not found");
                }
                _context.Jobs.Remove(job);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting job: {ex.Message}");
            }
        }
    }

}

