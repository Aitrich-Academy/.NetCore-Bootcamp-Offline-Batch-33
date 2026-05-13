using AutoMapper;
using Domain.Interviews.Dto;
using Domain.Interviews.Interface;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interviews
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

        public async Task<List<InterviewResponseDto>> GetInterviewsAsync()
        {
            var interviews = await _interviewRepository .GetInterviewsAsync();
            return _mapper.Map<List<InterviewResponseDto>>(interviews);
        }
        public async Task<InterviewResponseDto> GetInterviewByIdAsync(Guid interviewId)
        {
            var interview = await _interviewRepository.GetInterviewByIdAsync(interviewId);
            if (interview == null)
            {
                return null;
            }

            return _mapper.Map<InterviewResponseDto>(interview);
        }
        public async Task<InterviewResponseDto> UpdateInterviewAsync(UpdateInterviewDto updateInterviewDto)
        {
            var updatedInterview = await _interviewRepository .UpdateInterviewAsync(updateInterviewDto);
            return _mapper.Map<InterviewResponseDto>(updatedInterview);
        }
        public async Task<bool> DeleteInterviewAsync(Guid interviewId)
        {
            return await _interviewRepository .DeleteInterviewAsync (interviewId);
        }
    }
}
