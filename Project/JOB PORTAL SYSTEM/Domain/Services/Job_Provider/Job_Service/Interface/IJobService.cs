using Domain.Models;
using Domain.Services.Job_Provider.Job_Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Job_Provider.Job_Service.Interface
{
    public interface IJobService
    {
        public Task<JobDto> CreateJobAsync(CreateJobDto dto);
        public Task<JobDto> GetJobByIdAsync(Guid jobId);
        public Task<IEnumerable<JobDto>> GetAllJobsAsync();
        public Task<JobDto> UpdateJobAsync(Guid jobId, UpdateJobDto dto);
        public Task<bool> DeleteJobAsync(Guid jobId);
    }
}
