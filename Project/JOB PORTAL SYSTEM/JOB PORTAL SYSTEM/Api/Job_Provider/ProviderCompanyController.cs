using AutoMapper;
using Domain.Models;
using Domain.Services.Job_Provider.CompanyProfile.DTO;
using Domain.Services.Job_Provider.CompanyProfile.Interface;
using JOB_PORTAL_SYSTEM.Api.Job_ProviderModule.RequestObject;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace JOB_PORTAL_SYSTEM.Api.Job_Provider
{

    [Tags("03-ProviderCompany")]
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "JobProvider")]
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
                // Get JobProviderId from JWT Token
                var providerIdClaim = User.FindFirst(ClaimTypes.Sid)?.Value;

                if (string.IsNullOrEmpty(providerIdClaim))
                {
                    return Unauthorized("You are not authorized to perform this action");
                }

                Guid providerId = Guid.Parse(providerIdClaim);

                //var companyIdClaim = User.FindFirst("CompanyId")?.Value;
                //if (string.IsNullOrEmpty(companyIdClaim))
                //{
                //    return Unauthorized("Invalid token");
                //}

                //var loggedInCompanyId = Guid.Parse(companyIdClaim);


                var company = await companyService.AddCompanyAsync(request, providerId);

                if (company == null)
                {
                    return BadRequest("Failed to create company profile.");
                }

                var response = mapper.Map<CompanyProfileDto>(company);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("All")]
        [Authorize]
        public async Task<IActionResult> GetAllCompanyProfiles()
        {
            try
            {
                var company = await companyService.GetAllCompaniesByProviderIdAsync();
                var response = mapper.Map<IEnumerable<CompanyProfileDto>>(company);
                return Ok(response);

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet()]
        [Authorize]
        public async Task<IActionResult> GetCompanyProfileById()
        {
            try
            {
                var companyIdClaim = User.FindFirst("CompanyId")?.Value;
                if (string.IsNullOrEmpty(companyIdClaim))
                    return Unauthorized("You are not authorized to perform this action.");

                var loggedInCompanyId = Guid.Parse(companyIdClaim);



                var company = await companyService.GetCompanyByIdAsync(loggedInCompanyId);
                if (company == null)
                {
                    return NotFound("No records found for the given CompanyId");
                }
                var response = mapper.Map<CompanyProfileDto>(company);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPut("{CompanyId}")]
        [Authorize]

        public async Task<IActionResult> UpdateCompanyProfile([FromBody] UpdateCompanyProfileRequest request)
        {
            try
            {
                var companyIdClaim = User.FindFirst("CompanyId")?.Value;
                if (string.IsNullOrEmpty(companyIdClaim))
                    return Unauthorized("CompanyId claim is missing or invalid.");

                var loggedInCompanyId = Guid.Parse(companyIdClaim);



                var company = mapper.Map<Company>(request);
                var updatedCompany = await companyService.UpdateCompanyAsync(loggedInCompanyId, company);
                if (updatedCompany == null)
                {
                    return NotFound("No records found for the given CompanyId");
                }
                var response = mapper.Map<CompanyProfileDto>(updatedCompany);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteCompanyProfile()
        {
            try
            {
                var companyIdClaim = User.FindFirst("CompanyId")?.Value;
                if (string.IsNullOrEmpty(companyIdClaim))
                {
                    return Unauthorized("CompanyId claim is missing or invalid.");
                }

                var loggedInCompanyId = Guid.Parse(companyIdClaim);


                var deleted = await companyService.DeleteCompanyAsync(loggedInCompanyId);
                if (!deleted)
                {
                    return NotFound("No records found for the given CompanyId");
                }
                return Ok("Company Deleted");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
