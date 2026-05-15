using Domain.Data;
using Domain.Enums;
using Domain.Services.Admin.CompanyVerification.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services.Admin.CompanyVerification
{

    public class JobsRepository : IJobsRepository
    {
        private readonly AppDbContext _context;

        public JobsRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> GetTotalJobsAsync(Guid companyId)
        {
            return await _context.Jobs
                .Where(j => j.CompanyId == companyId)
                .CountAsync();
        }

        public async Task<int> GetCountByStatusAsync(Guid companyId, JobStatus status)
        {
            return await _context.Jobs
                .Where(j => j.CompanyId == companyId && j.Status == status)
                .CountAsync();
        }
    }
}
