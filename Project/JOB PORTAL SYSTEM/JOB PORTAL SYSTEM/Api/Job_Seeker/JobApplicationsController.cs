using Domain.Services.Job_Seeker.Applications.DTOs;
using Domain.Services.Job_Seeker.Applications.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace JOB_PORTAL_SYSTEM.Api.Job_Seeker
{
    [Route("api/jobseekers/applications")]
    [ApiController]
    public class JobApplicationsController : ControllerBase
    {
        private readonly IJobApplicationService _service;

        public JobApplicationsController(IJobApplicationService service)
        {
            _service = service;
        }

        [HttpPost]
        [Authorize(Roles = "JobSeeker")]
        public async Task<IActionResult> ApplyJob([FromBody] ApplyJobDto dto)
        {
            try
            {
                var claim = User.FindFirst(ClaimTypes.NameIdentifier);

                if (claim == null)
                    return Unauthorized();

                var jobSeekerId = Guid.Parse(claim.Value);
                await _service.ApplyJobAsync(jobSeekerId, dto);

                return Created("", new
                {
                    success = true,
                    message = "Job application submitted successfully"
                });
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(new
                {
                    success = false,
                    message = ex.Message
                });
            }
            catch (Exception)
            {
                return StatusCode(500, new
                {
                    success = false,
                    message = "Something went wrong"
                });
            }
        }

        [HttpGet]
        [Authorize(Roles = "JobSeeker")]
        public async Task<IActionResult> GetMyApplications()
        {
            try
            {
                var claim = User.FindFirst(ClaimTypes.NameIdentifier);

                if (claim == null)
                    return Unauthorized();

                var jobSeekerId = Guid.Parse(claim.Value);
                var result = await _service.GetMyApplicationsAsync(jobSeekerId);

                return Ok(new
                {
                    success = true,
                    message = "Applications fetched successfully",
                    data = result
                });
            }

            catch (Exception)
            {
                return StatusCode(500, new
                {
                    success = false,
                    message = "Something went wrong"
                });
            }
        }
    }
}
