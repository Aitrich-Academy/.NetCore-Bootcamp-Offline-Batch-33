//using Domain.Services.Admin.CompanyVerification.Interface;
//using Domain.Services.Admin.Dto;
//using Domain.Services.Admin.Interface;
//using Domain.Services.Jobs.Interfaces;
//using JOB_PORTAL_SYSTEM.Api.ADMIN.RequestObjects;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace JOB_PORTAL_SYSTEM.Api.ADMIN
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class PlatFormAdminController : ControllerBase
//    {
//        private readonly Domain.Services.Admin.CompanyVerification.Interface.IAdminService _companyService;
//        private readonly IJobService _jobService;
//        private readonly ISkillService _skillService;

//        public PlatFormAdminController(Domain.Services.Admin.CompanyVerification.Interface.IAdminService companyService, IJobService jobService, ISkillService skillService)
//        {
//            _companyService = companyService;
//            _jobService = jobService;
//            _skillService = skillService;
//        }

//        //[Authorize(Roles = "Admin")]
//        [HttpPut("company-verification/{Id}/verify")]
//        public async Task<IActionResult> VerifyCompany(Guid Id)
//        {
//            try
//            {
//                var result = await _companyService.VerifyCompanyAsync(Id);

//                if (!result)
//                    return NotFound("Company not found");

//                return Ok("Company verified successfully");
//            }
//            catch (Exception ex)
//            {
//                return StatusCode(500, ex.Message);
//            }
//        }

//        [HttpGet("profiles/{id}")]
//        public async Task<IActionResult> GetCompanyProfile(Guid id)
//        {
//            try
//            {
//                var profile = await _companyService.GetCompanyProfileByIdAsync(id);

//                if (profile == null)
//                    return NotFound();

//                return Ok(profile);
//            }
//            catch(Exception ex)
//            {
//                return StatusCode(500, ex.Message);
//            }
//        }

//        [HttpGet("stats/{companyId}")]
//        public async Task<IActionResult> GetJobStats(Guid companyId)
//        {
//            try
//            {
//                var stats = await _jobService.GetJobStatsAsync(companyId);
//                return Ok(stats);
//            }
//            catch (Exception ex)
//            {
//                return StatusCode(500, ex.Message);
//            }
//        }
//        [HttpPost("add-skills")]
//        public async Task<IActionResult> AddSkills([FromBody] List<AddSkillDto> skills)
//        {
//            try
//            {
//                foreach (var skill in skills)
//                {
//                    skill.Id = Guid.NewGuid();
//                    await _skillService.AddSkillAsync(skill);
//                }
//                return Ok("Skills added successfully");
//                //var skill = await _skillService.AddSkillAsync(skillId);
//                //return Ok("Skills added successfully");
//            }
//            catch (Exception ex)
//            {
//                return StatusCode(500, ex.Message);
//            }
//        }
//        [HttpGet("skills/{skillId}")]
//        public async Task<IActionResult> GetSkillById(Guid skillId)
//        {
//            try
//            {
//                var skill = await _skillService.GetSkillByIdAsync(skillId);
//                if (skill == null)
//                    return NotFound("Skill not found");
//                return Ok(skill);
//            }
//            catch (Exception ex)
//            {
//                return StatusCode(500, ex.Message);
//            }
//        }
//        [HttpPut("update-skills")]
//        public async Task<IActionResult> UpdateSkills([FromBody] List<UpdateSkillDto> skills)
//        {
//            try
//            {
//                foreach (var skill in skills)
//                {
//                    await _skillService.UpdateSkillAsync(skill);
//                }
//                return Ok("Skills updated successfully");
//            }
//            catch (Exception ex)
//            {
//                return StatusCode(500, ex.Message);
//            }
//        }
//        [HttpDelete("delete-skills/{skillId}")]
//        public async Task<IActionResult> DeleteSkills(Guid skillId)
//        {
//            try
//            {
//                var result = await _skillService.DeleteSkillAsync(skillId);
//                if (result == null)
//                    return NotFound("Skill not found");
//                return Ok("Skill deleted successfully");
//            }
//            catch (Exception ex)
//            {
//                return StatusCode(500, ex.Message);
//            }
//        }
//    }
//}
