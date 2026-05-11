using Domain.Data;
using Domain.Models;
using Domain.Services.Job_Provider.Job_Service.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Job_Provider.Job_Service
{
    public class JobRepository : IJobRepository
    {
        private readonly AppDbContext dbContext;
        public JobRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Job> AddJobAsync(Job job)
        {
            try
            {
                var company = await dbContext.Companies.FindAsync(job.CompanyId);
                if (company == null)
                {
                    throw new Exception("Company not found");
                }
                var category = await dbContext.JobCategories.FindAsync(job.CategoryId);
                if (category == null)
                {
                    throw new Exception("Category not found");
                }
                var location = await dbContext.Locations.FindAsync(job.LocationId);
                if (location == null)
                {
                    throw new Exception("Location not found");
                }
                dbContext.Jobs.Add(job);
                await dbContext.SaveChangesAsync();
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
                var job = await dbContext.Jobs.FindAsync(jobId);
                if (job == null)
                {
                    return null;
                }

                return await dbContext.Jobs
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
                if (!await dbContext.Jobs.AnyAsync())
                {
                    return new List<Job>();
                }
                return await dbContext.Jobs
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
                var existingJob = await dbContext.Jobs.FindAsync(job.Id);
                if (existingJob == null)
                {
                    throw new Exception("Job not found");
                }
                var company = await dbContext.Companies.FindAsync(job.CompanyId);
                if (company == null)
                {
                    throw new Exception("Company not found");
                }
                var category = await dbContext.JobCategories.FindAsync(job.CategoryId);
                if (category == null)
                {
                    throw new Exception("Category not found");
                }
                var location = await dbContext.Locations.FindAsync(job.LocationId);
                if (location == null)
                {
                    throw new Exception("Location not found");
                }
                dbContext.Jobs.Update(job);
                await dbContext.SaveChangesAsync();
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
                var job = await dbContext.Jobs.FindAsync(jobId);
                if (job == null)
                {
                    return false;
                }
                dbContext.Jobs.Remove(job);
                await dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting job: {ex.Message}");
            }
        }
    }
}
