using Domain.Data;
using Domain.Models;
using Domain.Services.Signup.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Signup
{
    public class SignUpRequestRepository:ISignUpRequestRepository 
    {
        private readonly AppDbContext _context;

        public SignUpRequestRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task AddJobProviderAsync(JobProvider jobProvider)
        {
            await _context.JobProviders.AddAsync (jobProvider);
            await _context.SaveChangesAsync();
        }

        public Guid AddSignupRequest(SignupRequest signUpRequest)
        {
            signUpRequest.JobStatus = Enums.JobStatus.Pending;
            _context.SignupRequests .AddAsync (signUpRequest);
            _context.SaveChanges();
            return signUpRequest.Id;
        }
        public async Task<SignupRequest> GetSignupRequestByIdAsync(Guid jobproviderSignupRequestId)
        {
            return await _context .SignupRequests .FindAsync (jobproviderSignupRequestId);
        }

        public void UpdateSignupRequest(SignupRequest signupRequest)
        {
            _context .SignupRequests .Update (signupRequest);
            _context.SaveChanges ();
        }
    }
}
