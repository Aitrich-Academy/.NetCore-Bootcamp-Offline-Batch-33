using Domain.Services.Job_Seeker.SavedJobs.DTOs;
using Domain.Services.Job_Seeker.SavedJobs.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace JOB_PORTAL_SYSTEM.Api.Job_Seeker
{
    [Route("api/v1/jobseekers/saved-jobs")]
    [ApiController]
    public class SavedJobsController : ControllerBase
    {
        private readonly ISavedJobService _service;

        public SavedJobsController(ISavedJobService service)
        {
            _service = service;
        }

        [HttpPost]
        [Authorize(Roles = "JobSeeker")]
        public async Task<IActionResult> SaveJob([FromBody] SavedJobDto dto)
        {
            try
            {
                var claim = User.FindFirst(ClaimTypes.NameIdentifier);

                if (claim == null)
                    return Unauthorized();

                var jobSeekerId = Guid.Parse(claim.Value);
                await _service.SavedJobAsync(jobSeekerId, dto);

                return Created("", new
                {
                    success = true,
                    message = "Job saved successfully"
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
        public async Task<IActionResult> GetSavedJobs()
        {
            try
            {
                var claim = User.FindFirst(ClaimTypes.NameIdentifier);

                if (claim == null)
                    return Unauthorized();

                var jobSeekerId = Guid.Parse(claim.Value);
                var result = await _service.GetSavedJobsAsync(jobSeekerId);

                return Ok(new
                {
                    success = true,
                    message = "Saved jobs fetched successfully",
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

        [HttpDelete("{jobId}")]
        [Authorize(Roles = "JobSeeker")]
        public async Task<IActionResult> DeleteSavedJob(Guid jobId)
        {
            try
            {
                var claim = User.FindFirst(ClaimTypes.NameIdentifier);

                if (claim == null)
                    return Unauthorized();

                var jobSeekerId = Guid.Parse(claim.Value);

                await _service.RemoveSavedJobAsync(jobSeekerId, jobId);

                return Ok(new
                {
                    success = true,
                    message = "Removed saved job successfully"
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    success = false,
                    message = ex.Message
                });
            }
        }

    }
}
