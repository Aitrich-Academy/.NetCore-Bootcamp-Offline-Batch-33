using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Job_Provider.Job_Service.Interface
{
    public interface IJobRepository
    {
        Task<Job> AddJobAsync(Job job);
        Task<Job?> GetJobByIdAsync(Guid jobId);
        Task<IEnumerable<Job>> GetAllJobsAsync();
        Task<Job> UpdateJobAsync(Job job);
        Task<bool> DeleteJobAsync(Guid jobId);
    }
}
