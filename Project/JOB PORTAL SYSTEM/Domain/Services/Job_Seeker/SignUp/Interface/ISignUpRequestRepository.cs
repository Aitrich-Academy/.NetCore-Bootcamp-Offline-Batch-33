using Domain.Models;

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
