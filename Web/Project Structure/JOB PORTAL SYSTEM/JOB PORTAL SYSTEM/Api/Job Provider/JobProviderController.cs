using AutoMapper;
using Domain.Models;
using Domain.Services.JobProvider.Profile.DTO;
using Domain.Services.JobProvider.Profile.Interface;
using JOB_PORTAL_SYSTEM.Api.Job_Provider.RequestObjects;
using JOB_PORTAL_SYSTEM.Api.JobSeeker.RequestObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JOB_PORTAL_SYSTEM.Api.JobSeeker
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobProviderController : ControllerBase
    {
        readonly ICompanyService companyService;
        readonly IMapper mapper;
        public JobProviderController(ICompanyService companyService, IMapper mapper)
        {
            this.companyService = companyService;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCompanyProfile([FromBody] CreateCompanyProfileRequest request)
        {
            try
            {
                var company = await companyService.AddCompanyAsync(
                    request.CompanyName,
                    request.Description,
                    request.IndustryId,
                    request.LocationId,
                    request.AuthId // later replace with user id from token
                    );
                var response = mapper.Map<CompanyProfileDto>(company);
                return Ok(response);

            }
            catch (Exception ex)
            {
                // Log the exception (ex) here as needed
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("user/{userId}")]
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
                if (deleted == null)
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
