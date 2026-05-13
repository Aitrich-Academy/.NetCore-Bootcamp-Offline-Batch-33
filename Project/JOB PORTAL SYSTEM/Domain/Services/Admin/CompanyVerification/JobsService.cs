using AutoMapper;
using Domain.Enums;
using Domain.Services.Admin.CompanyVerification.Dto;
using Domain.Services.Admin.CompanyVerification.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Admin.CompanyVerification
{
    public class JobsService : IJobsService
    {
        private readonly IJobsRepository _jobsRepository;

        public JobsService(IJobsRepository jobsRepository)
        {
            _jobsRepository = jobsRepository;
        }

        public async Task<JobStatsDto> GetJobStatsAsync(Guid companyId)
        {
            return new JobStatsDto
            {
                TotalJobs = await _jobsRepository.GetTotalJobsAsync(companyId),
                CreatedJobs = await _jobsRepository.GetCountByStatusAsync(companyId, JobStatus.Created),
                PendingJobs = await _jobsRepository.GetCountByStatusAsync(companyId, JobStatus.Pending),
                ActiveJobs = await _jobsRepository.GetCountByStatusAsync(companyId, JobStatus.Active),
                ClosedJobs = await _jobsRepository.GetCountByStatusAsync(companyId, JobStatus.Closed),
                VerifiedJobs = await _jobsRepository.GetCountByStatusAsync(companyId, JobStatus.Verified)
            };
        }
    }
}
