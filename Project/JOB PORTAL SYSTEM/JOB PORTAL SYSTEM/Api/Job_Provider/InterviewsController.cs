using AutoMapper;
using Domain.Services.Job_Provider.Interviews.Dto;
using Domain.Services.Job_Provider.Interviews.Interface;
using JOB_PORTAL_SYSTEM.Api.Job_Provider.RequestObjects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JOB_PORTAL_SYSTEM.Api.Job_Provider
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterviewsController : ControllerBase
    {
        private readonly IInterviewService _interviewService;
        private readonly IMapper _mapper;

        public InterviewsController (IInterviewService interviewService , IMapper mapper)
        {
            _interviewService = interviewService;
            _mapper = mapper;
        }

        [Authorize (Roles = "JobProvider" )]
        [HttpPost("ScheduleInterview")]
        public async Task<IActionResult> ScheduleInterview(CreateInterviewRequest createInterviewRequest)
        {

            var interviewDto = _mapper.Map<CreateInterviewDto>(createInterviewRequest);

            var scheduledInterview = await _interviewService.ScheduleInterviewAsync(interviewDto);

            if (!scheduledInterview)
            {
                return BadRequest("ApplicationId is invalid or does not belong to your company.");
            }

            return Ok("Interview scheduled successfully");

        }

        [Authorize(Roles = "JobProvider")]
        [HttpGet("{interviewId}/GetInterviewById")]
        public async Task<IActionResult> GetInterviewById(Guid interviewId)
        {
            var companyIdClaim = User.FindFirst("CompanyId")?.Value;
            if (string.IsNullOrEmpty(companyIdClaim))
                return Unauthorized();

            var loggedInCompanyId = Guid.Parse(companyIdClaim);

            var interview = await _interviewService.GetInterviewByIdAsync(interviewId, loggedInCompanyId);
            if (interview == null)
            {
                return BadRequest("Interview not found for the given company.");
            }
            return Ok(interview);
        }

        [Authorize(Roles = "JobProvider")]
        [HttpGet("GetInterviews")]
        public async Task<IActionResult> GetInterview()
        {
            var companyIdClaim = User.FindFirst("CompanyId")?.Value;
            if (string.IsNullOrEmpty(companyIdClaim))
                return Unauthorized();

            var loggedInCompanyId = Guid.Parse(companyIdClaim);

            var interview = await _interviewService.GetInterviewsAsync(loggedInCompanyId);
            if (interview == null || !interview.Any())
            {
                return BadRequest("No interviews found.");
            }

            return Ok(interview);
        }

        [Authorize(Roles = "JobProvider")]
        [HttpPut("UpdateInterview")]
        public async Task <IActionResult > UpdateInterview([FromBody ] UpdateInterviewDto updateInterviewDto)
        {
            try
            {
                var companyIdClaim = User.FindFirst("CompanyId")?.Value;
                if (string.IsNullOrEmpty(companyIdClaim))
                    return Unauthorized();

                var loggedInCompanyId = Guid.Parse(companyIdClaim);

                var result = await _interviewService.UpdateInterviewAsync(updateInterviewDto, loggedInCompanyId);
                if (result != null)
                {
                    return Ok(result);
                }
                return BadRequest("Interview does not exist or is not owned by your company.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [Authorize(Roles = "JobProvider")]
        [HttpDelete("{interviewId}/DeleteInterview")]
        public async Task<IActionResult> DeleteInterview(Guid interviewId)
        {
            try
            {
                var companyIdClaim = User.FindFirst("CompanyId")?.Value;
                if (string.IsNullOrEmpty(companyIdClaim))
                    return Unauthorized();

                var loggedInCompanyId = Guid.Parse(companyIdClaim);

                var Deleteinterview = await _interviewService.DeleteInterviewAsync(interviewId, loggedInCompanyId);
                if (!Deleteinterview)
                {
                    return BadRequest("Interview not found or already deleted.");
                }

                return Ok("Interview deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
