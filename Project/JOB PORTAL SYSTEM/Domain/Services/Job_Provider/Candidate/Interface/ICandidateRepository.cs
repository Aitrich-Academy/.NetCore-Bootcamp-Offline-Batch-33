using Domain.Models;
using Domain.Services.Job_Provider.Candidate.Dto;


namespace Domain.Services.Job_Provider.Candidate.Interface
{
    public interface ICandidateRepository
    {
        Task<List<JobSeeker>> FilterCandidatesAsync(string skill);

    }
}
