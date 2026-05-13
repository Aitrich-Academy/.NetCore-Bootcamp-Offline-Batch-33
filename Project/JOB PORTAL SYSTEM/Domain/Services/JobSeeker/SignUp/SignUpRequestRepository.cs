using Domain.Data;
using Domain.Models;
using Domain.Service.SignUp.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class SignUpRequestRepository : ISignUpRequestRepository
    {
        private readonly AppDbContext _context;

        public SignUpRequestRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddJobSeekerAsync(JobSeeker jobSeeker)
        {
            _context.JobSeekers.Add(jobSeeker);
            await _context.SaveChangesAsync();
        }
        public async Task<Guid> AddSignUpRequest(SignupRequest signUpRequest)
        {
            signUpRequest.JobStatus = Enums.JobStatus.Pending;

            await _context.SignupRequests.AddAsync(signUpRequest);
            await _context.SaveChangesAsync();

            return signUpRequest.Id;
        }
        public async Task<SignupRequest> GetSignupRequestByIdAsync(Guid jobseekersignuprequestId)
        {
            return await _context.SignupRequests.FindAsync(jobseekersignuprequestId);
        }
        public async Task UpdateSignUpRequest(SignupRequest signUpRequest)
        {
            _context.SignupRequests.Update(signUpRequest);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> JobSeekerExists(Guid jobSeekerId)
        {
            return await _context.JobSeekers.AnyAsync(x => x.Id == jobSeekerId);
        }
    }
}
