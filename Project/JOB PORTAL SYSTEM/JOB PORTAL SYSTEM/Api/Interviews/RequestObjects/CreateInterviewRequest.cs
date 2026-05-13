using Domain.Enums;

namespace JOB_PORTAL_SYSTEM.API.Interviews.RequestObjects
{
    public class CreateInterviewRequest
    {
        public Guid ApplicationId { get; set; }

        public DateTime InterviewDate { get; set; }

        public InterviewMode Mode { get; set; }

        public InterviewStatus Status { get; set; }
    }
}
