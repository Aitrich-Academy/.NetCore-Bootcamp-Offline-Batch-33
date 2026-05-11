using AutoMapper;
using Domain.Enums;
using Domain.Models;
using Domain.Services.Job_Provider.CompanyProfile.DTO;
using Domain.Services.Job_Provider.CompanyProfile.Interface;
using JOB_PORTAL_SYSTEM.Api.Job_Provider.RequestObjects;
using JOB_PORTAL_SYSTEM.Api.JobSeeker.RequestObjects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace JOB_PORTAL_SYSTEM.Api.JobSeeker
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderCompanyController : ControllerBase
    {
        readonly ICompanyService companyService;
        readonly IMapper mapper;
        public ProviderCompanyController(ICompanyService companyService, IMapper mapper)
        {
            this.companyService = companyService;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCompanyProfile([FromBody] Domain.Services.Job_Provider.CompanyProfile.DTO.CreateCompanyProfileRequest request)
        {
            try
            {
                //var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

                //var company = await companyService.AddCompanyAsync(
                //    request.CompanyName,
                //    request.Description,
                //    request.IndustryId,
                //    request.LocationId,
                //    request.UserId
                //    );
                var response = mapper.Map<CompanyProfileDto>(request);
                return Ok(response);

            }
            catch (Exception ex)
            {
                // Log the exception (ex) here as needed
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("user")]
        public async Task<IActionResult> GetCompanyProfileByUserId(Guid userId)
        {
            try
            {
                var company = await companyService.GetAllCompaniesByUserIdAsync(userId);
                var response = mapper.Map<IEnumerable<CompanyProfileDto>>(company);
                return Ok(response);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCompanyProfileById(Guid id)
        {
            try
            {
                var company = await companyService.GetCompanyByIdAsync(id);
                if (company == null)
                {
                    return NotFound("Company not found");
                }
                var response = mapper.Map<CompanyProfileDto>(company);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("{CompanyId}")]
        public async Task<IActionResult> UpdateCompanyProfile(Guid CompanyId, [FromBody] UpdateCompanyProfileRequest request)
        {
            try
            {
                var company = mapper.Map<Company>(request);
                var updatedCompany = await companyService.UpdateCompanyAsync(CompanyId, company);
                if (updatedCompany == null)
                {
                    return NotFound("Company not found");
                }
                var response = mapper.Map<CompanyProfileDto>(updatedCompany);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompanyProfile(Guid id)
        {
            try
            {
                var deleted = await companyService.DeleteCompanyAsync(id);
                if (!deleted)
                {
                    return NotFound("Company not found");
                }
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
