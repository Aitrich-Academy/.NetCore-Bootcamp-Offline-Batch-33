using Domain.Services.Admin.CompanyVerification.Interface;
using Domain.Services.Admin.Skills.Dto;
using Domain.Services.Admin.Skills.Interfaces;
using JOB_PORTAL_SYSTEM.Api.ADMIN.RequestObjects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JOB_PORTAL_SYSTEM.Api.ADMIN
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatFormAdminController : ControllerBase
    {
        private readonly IAdminService _companyService;
        private readonly IJobsService _jobsService;
        private readonly ISkillService _skillService;

        public PlatFormAdminController(IAdminService companyService, IJobsService jobsService, ISkillService skillService)
        {
            _companyService = companyService;
            _jobsService = jobsService;
            _skillService = skillService;
        }

        //[Authorize(Roles = "Admin")]
        [HttpPut("company-verification/{userId}/verify")]
        public async Task<IActionResult> VerifyCompany(Guid userId)
        {
            try
            {
                var result = await _companyService.VerifyCompanyAsync(userId);

                if (!result)
                    return NotFound("Company not found");

                return Ok("Company verified successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("profiles/{id}")]
        public async Task<IActionResult> GetCompanyProfile(Guid id)
        {
            var profile = await _companyService.GetCompanyProfileByIdAsync(id);

            if (profile == null)
                return NotFound();

            return Ok(profile);
        }

        [HttpGet("stats/{companyId}")]
        public async Task<IActionResult> GetJobStats(Guid companyId)
        {
            try
            {
                var stats = await _jobsService.GetJobStatsAsync(companyId);
                return Ok(stats);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost("add-skills")]
        public async Task<IActionResult> AddSkills([FromBody] List<AddSkillDto> skills)
        {
            try
            {
                foreach (var skill in skills)
                {
                    skill.Id = Guid.NewGuid();
                    await _skillService.AddSkillAsync(skill);
                }
                return Ok("Skills added successfully");
                //var skill = await _skillService.AddSkillAsync(skillId);
                //return Ok("Skills added successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("skills/{skillId}")]
        public async Task<IActionResult> GetSkillById(Guid skillId)
        {
            try
            {
                var skill = await _skillService.GetSkillByIdAsync(skillId);
                if (skill == null)
                    return NotFound("Skill not found");
                return Ok(skill);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPut("update-skills")]
        public async Task<IActionResult> UpdateSkills([FromBody] List<UpdateSkillDto> skills)
        {
            try
            {
                foreach (var skill in skills)
                {
                    await _skillService.UpdateSkillAsync(skill);
                }
                return Ok("Skills updated successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpDelete("delete-skills/{skillId}")]
        public async Task<IActionResult> DeleteSkills(Guid skillId)
        {
            try
            {
                var result = await _skillService.DeleteSkillAsync(skillId);
                if (result == null)
                    return NotFound("Skill not found");
                return Ok("Skill deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
