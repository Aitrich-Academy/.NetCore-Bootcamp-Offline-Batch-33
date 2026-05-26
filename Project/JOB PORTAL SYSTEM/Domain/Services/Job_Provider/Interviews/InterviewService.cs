using AutoMapper;
using Domain.Models;
using Domain.Services.Job_Provider.Interviews.Dto;
using Domain.Services.Job_Provider.Interviews.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Job_Provider.Interviews
{
    public class InterviewService:IInterviewService 
    {
        private readonly IInterviewRepository _interviewRepository;
        private readonly IMapper _mapper;

        public InterviewService (IInterviewRepository interviewRepository, IMapper mapper)
        {
            _interviewRepository = interviewRepository;
            _mapper = mapper;
        }

        public async Task<bool> ScheduleInterviewAsync(CreateInterviewDto interviewdto)
        {
            var interview = _mapper.Map <Interview >(interviewdto);
            return await _interviewRepository.ScheduleInterviewAsync(interview);
        }

        public async Task<List<InterviewResponseDto>> GetInterviewsAsync(Guid comapanyId)
        {
            var interviews = await _interviewRepository.GetInterviewsByCompanyAsync(comapanyId);
            return _mapper.Map<List<InterviewResponseDto>>(interviews);
        }
        public async Task<InterviewResponseDto> GetInterviewByIdAsync(Guid interviewId, Guid companyId)
        {
            var interview = await _interviewRepository.GetInterviewByIdAsync(interviewId, companyId);
            if (interview == null)
            {
                throw new DirectoryNotFoundException($"Interview with Id {interviewId} for CompanyId {companyId} not found.");
            }

            return _mapper.Map<InterviewResponseDto>(interview);
        }
        public async Task<InterviewResponseDto> UpdateInterviewAsync(UpdateInterviewDto updateInterviewDto, Guid companyId)
        {
            var updatedInterview = await _interviewRepository.UpdateInterviewAsync(updateInterviewDto, companyId);
            return _mapper.Map<InterviewResponseDto>(updatedInterview);
        }
        public async Task<bool> DeleteInterviewAsync(Guid interviewId, Guid companyId)
        {
            return await _interviewRepository.DeleteInterviewAsync(interviewId, companyId);
        }
    }
}
