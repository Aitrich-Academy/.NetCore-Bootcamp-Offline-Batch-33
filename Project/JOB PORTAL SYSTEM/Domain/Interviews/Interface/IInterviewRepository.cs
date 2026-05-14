using Domain.Interviews.Dto;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interviews.Interface
{
    public interface IInterviewRepository
    {
        Task<bool> ScheduleInterviewAsync(Interview interview);
        Task<List<Interview>> GetInterviewsAsync();
        Task<Interview> GetInterviewByIdAsync(Guid interviewId);
        Task<InterviewResponseDto> UpdateInterviewAsync(UpdateInterviewDto updateInterviewDto);
        Task<bool> DeleteInterviewAsync(Guid interviewId);
    }
}
