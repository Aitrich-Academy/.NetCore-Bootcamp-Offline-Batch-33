using Domain.Models;
using Domain.Services.Job_Provider.Interviews.Dto;


namespace Domain.Services.Job_Provider.Interviews.Interface
{
    public interface IInterviewService
    {
        Task<bool> ScheduleInterviewAsync(CreateInterviewDto interviewdto);
        Task<List<InterviewResponseDto>> GetInterviewsAsync(Guid companyId);
        Task<InterviewResponseDto> GetInterviewByIdAsync(Guid interviewId, Guid companyId);
        Task<InterviewResponseDto> UpdateInterviewAsync(UpdateInterviewDto updateInterviewDto, Guid companyId);
        Task<bool> DeleteInterviewAsync(Guid interviewId, Guid companyId);
    }
}
