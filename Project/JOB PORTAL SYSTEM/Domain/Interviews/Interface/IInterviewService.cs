using Domain.Interviews.Dto;
using Domain.Models;


namespace Domain.Interviews.Interface
{
    public interface IInterviewService
    {
        Task<bool> ScheduleInterviewAsync(CreateInterviewDto interviewdto);
        Task<List<InterviewResponseDto>> GetInterviewsAsync();
        Task<InterviewResponseDto> GetInterviewByIdAsync(Guid interviewId);
        Task<InterviewResponseDto> UpdateInterviewAsync(UpdateInterviewDto updateInterviewDto);
        Task<bool> DeleteInterviewAsync(Guid interviewId);
    }
}
