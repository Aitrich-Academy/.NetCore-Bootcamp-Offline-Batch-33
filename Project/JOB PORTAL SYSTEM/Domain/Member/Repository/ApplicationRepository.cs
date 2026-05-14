using Domain.Data;
using Domain.Member.Interface;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Member.Repository
{
    public class ApplicationRepository : IApplicationRepository
    {
        private readonly AppDbContext _context;

        public ApplicationRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<JobApplication> GetByIdAsync(Guid id)
        {
            return await _context.JobApplications.FindAsync(id);
        }

        public async Task<JobApplication> UpdateAsync(JobApplication application)
        {
            _context.JobApplications.Update(application);

            await _context.SaveChangesAsync();

            return application;
        }
    }
}