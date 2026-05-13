using AutoMapper;
using Domain.Services.Job_Seeker.Jobs.Interfaces;
using Domain.Services.Job_Seeker.Jobs.DTOs;

namespace Domain.Services.Job_Seeker.Jobs
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _repo;
        private readonly IMapper _mapper;

        public JobService(IJobRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<List<GetJobsDto>> GetAllJobsAsync()
        {
            var jobs = await _repo.GetAllAsync();

            return _mapper.Map<List<GetJobsDto>>(jobs);
        }

        public async Task<List<GetJobsDto>> SearchJobsAsync(string? keyword)
        {
            var jobs = await _repo.SearchAsync(keyword);

            return _mapper.Map<List<GetJobsDto>>(jobs);
        }
    }
}
