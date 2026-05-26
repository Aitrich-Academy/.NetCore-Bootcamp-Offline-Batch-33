using AutoMapper;
using Domain.Models;
using Domain.Services.Job_Provider.Job_Service.DTO;
using Domain.Services.Jobs.Interfaces;
using Domain.Services.Member.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JOB_PORTAL_SYSTEM.Api.Job_Provider
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles ="JobProvider")]
    

    public class JobController : ControllerBase
    {
        IJobService jobService;
        IMemberService memberService;
        IMapper mapper;
        public JobController(IJobService jobService, IMapper mapper)
        {
            this.jobService = jobService;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateJob([FromBody] CreateJobDto dto)
        {
            try
            {
                var companyIdClaim = User.FindFirst("CompanyId")?.Value;
                if (string.IsNullOrEmpty(companyIdClaim))
                    return Unauthorized();

                var loggedInCompanyId = Guid.Parse(companyIdClaim);

                // validate that the member belongs to this company
                var member = await memberService.GetByIdAsync(dto.CompanyMemberId);

                if (member == null || member.CompanyId != loggedInCompanyId)
                    return Forbid();

                var createdJob = await jobService.CreateJobAsync(dto, loggedInCompanyId);

                return CreatedAtAction(nameof(GetJob), new { id = createdJob.Id }, createdJob);

            }
            catch (Exception ex)
            {
                // Log the exception (ex) here as needed
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetJob(Guid id)
        {
            try
            {
                var companyIdClaim = User.FindFirst("CompanyId")?.Value;
                if (string.IsNullOrEmpty(companyIdClaim)) 
                    return Unauthorized();

                var loggedInCompanyId = Guid.Parse(companyIdClaim);

                var jobEntity = await jobService.GetJobEntityByIdAsync(id);
                if (jobEntity == null) 
                    return NotFound();

                if (jobEntity.CompanyId != loggedInCompanyId) 

                    return Forbid();


                var dto = mapper.Map<JobDto>(jobEntity);
                return Ok(dto);
            }
            catch (Exception ex)
            {
                // Log the exception (ex) here as needed
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllJobs()
        {
            try
            {
                var companyIdClaim = User.FindFirst("CompanyId")?.Value;
                if (string.IsNullOrEmpty(companyIdClaim))
                    return Unauthorized();

                var loggedInCompanyId = Guid.Parse(companyIdClaim);


                var jobs = await jobService.GetAllJobsAsync(loggedInCompanyId);
                return Ok(jobs);
            }
            catch (Exception ex)
            {
                // Log the exception (ex) here as needed
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateJob(Guid id, [FromBody] UpdateJobDto dto)
        {
            try
            {
                var companyIdClaim = User.FindFirst("CompanyId")?.Value;
                if (string.IsNullOrEmpty(companyIdClaim)) 
                    return Unauthorized();

                var loggedInCompanyId = Guid.Parse(companyIdClaim);

                var jobEntity = await jobService.GetJobEntityByIdAsync(id);
                if (jobEntity == null) 
                    return NotFound();

                if (jobEntity.CompanyId != loggedInCompanyId) 
                    return Forbid();




                // Pass entity into service
                var updatedJob = await jobService.UpdateJobAsync(id, dto);

                return Ok(updatedJob);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJob(Guid id)
        {
            try
            {
                var companyIdClaim = User.FindFirst("CompanyId")?.Value;
                if (string.IsNullOrEmpty(companyIdClaim)) 
                    return Unauthorized();

                var loggedInCompanyId = Guid.Parse(companyIdClaim);

                var jobEntity = await jobService.GetJobEntityByIdAsync(id);
                if (jobEntity == null) 
                    return NotFound();

                if (jobEntity.CompanyId != loggedInCompanyId) 
                    return Forbid();



                await jobService.DeleteJobAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                // Log the exception (ex) here as needed
                return BadRequest(ex.Message);
            }
        }
    }
}