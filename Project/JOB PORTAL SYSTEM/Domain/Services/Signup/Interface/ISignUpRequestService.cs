using Domain.Services.Signup.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Signup.Interface
{
    public interface ISignUpRequestService
    {
        Task CreateJobprovider(Guid jobproviderSignupRequestId, string password);

        Task<Guid> CreateSignupRequest(JobProviderSignupRequestDto data);

        Task<bool> VerifyEmailAsync(Guid jobproviderSignupRequestId);
    }
}
