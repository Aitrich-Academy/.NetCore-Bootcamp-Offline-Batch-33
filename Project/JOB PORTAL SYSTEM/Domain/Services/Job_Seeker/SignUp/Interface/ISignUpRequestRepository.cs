using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Job_Seeker.SignUp.Interface
{
    public interface ISignUpRequestRepository
    {
        Task AddJobSeekerAsync(JobSeeker jobSeeker);
        Task<Guid> AddSignUpRequest(SignupRequest signUpRequest);

        Task<SignupRequest> GetSignupRequestByIdAsync(Guid jobseekersignuprequestId);

        Task UpdateSignUpRequest(SignupRequest signUpRequest);

        Task<bool> JobSeekerExists(Guid jobSeekerId);
    }
}
