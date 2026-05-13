using Domain.Service.SignUp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.SignUp.Interface
{
    public interface ISignUpRequestService
    {
        Task CreateJobseeker(Guid jobSeekerSignupRequestId, string password);


        Task<Guid> CreateSignupRequest(JobSeekerRequestDTO data);

        Task<bool> VerifyEmailAsync(Guid jobSeekerSignupRequestId);

    }
}
