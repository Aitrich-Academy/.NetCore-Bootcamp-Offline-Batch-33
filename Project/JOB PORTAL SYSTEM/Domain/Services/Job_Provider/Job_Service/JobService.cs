using AutoMapper;
using Domain.Models;
using Domain.Services.Job_Provider.Job_Service.DTO;
using Domain.Services.Job_Provider.Job_Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Job_Provider.Job_Service
{
    public class JobService : IJobService
    {
        private readonly IJobRepository jobRepository;
        private readonly IMapper mapper;
        public JobService(IJobRepository jobRepository, IMapper mapper)
        {
            this.jobRepository = jobRepository;
            this.mapper = mapper;
        }

        public async Task<JobDto> CreateJobAsync(CreateJobDto dto)
        {
            try
            {
                var job = mapper.Map<Job>(dto);
                job.Id = Guid.NewGuid();
                job.CreatedAt = DateTime.UtcNow;

                var created = await jobRepository.AddJobAsync(job);

                return mapper.Map<JobDto>(created);
            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                throw new ApplicationException("An error occurred while creating the job.", ex);
            }
        }

        public async Task<JobDto> GetJobByIdAsync(Guid jobId)
        {
            try
            {
                var job = await jobRepository.GetJobByIdAsync(jobId);
                if (job == null)
                {
                    return null;
                }
                return mapper.Map<JobDto>(job);
            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                throw new ApplicationException("An error occurred while retrieving the job.", ex);
            }
        }

        public async Task<IEnumerable<JobDto>> GetAllJobsAsync()
        {
            try
            {
                var jobs = await jobRepository.GetAllJobsAsync();
                return jobs.Select(job => new JobDto
                {
                    Id = job.Id,
                    CompanyId = job.CompanyId,
                    CategoryId = job.CategoryId,
                    LocationId = job.LocationId,
                    Title = job.Title,
                    Description = job.Description,
                    Salary = job.Salary,
                    Status = job.Status,
                    CreatedAt = job.CreatedAt
                });

            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                throw new ApplicationException("An error occurred while retrieving jobs.", ex);
            }
        }

        public async Task<JobDto> UpdateJobAsync(Guid jobId, UpdateJobDto dto)
        {
            try
            {
                var job = await jobRepository.GetJobByIdAsync(jobId);
                if (job == null)
                {
                    throw new Exception("Job Not Found");
                }
                mapper.Map(dto, job);

                var updated = await jobRepository.UpdateJobAsync(job);
                return mapper.Map<JobDto>(updated);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while updating the job.", ex);
            }
        }


        public async Task<bool> DeleteJobAsync(Guid jobId)
        {
            try
            {
                var job = await jobRepository.GetJobByIdAsync(jobId);
                if (job == null)
                {
                    throw new Exception("Job not found");
                }
                return await jobRepository.DeleteJobAsync(jobId);

            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                throw new ApplicationException("An error occurred while deleting the job.", ex);
            }
        }
    }
}
