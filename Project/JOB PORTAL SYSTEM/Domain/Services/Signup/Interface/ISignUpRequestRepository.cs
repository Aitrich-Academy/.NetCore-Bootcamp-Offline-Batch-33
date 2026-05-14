using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Signup.Interface
{
    public interface ISignUpRequestRepository
    {
        Task AddJobProviderAsync(JobProvider jobProvider);
        Guid AddSignupRequest(SignupRequest signUpRequest);
        Task<SignupRequest> GetSignupRequestByIdAsync(Guid jobproviderSignupRequestId);

        void UpdateSignupRequest(SignupRequest signupRequest);
    }
}
