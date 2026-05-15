using Domain.Services.Job_Seeker.Interviews.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JOB_PORTAL_SYSTEM.Api.Job_Seeker
{
    [Route("/api/v1/jobseekers/{jobSeekerId}/interviews")]
    [ApiController]
    public class InterviewsController : ControllerBase
    {
        private readonly IInterviewService _service;

        public InterviewsController(IInterviewService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetMyInterviews(Guid jobSeekerId)
        {
            var result = await _service.GetMyInterviewsAsync(jobSeekerId);

            return Ok(new
            {
                success = true,
                message = "Interviews fetched successfully",
                data = result
            });
        }
    }
}
