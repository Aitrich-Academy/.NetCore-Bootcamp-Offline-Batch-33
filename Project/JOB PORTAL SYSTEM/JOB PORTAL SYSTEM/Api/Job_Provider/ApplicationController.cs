using Domain.Services.Job_Provider.ViewCompanyApplications.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JOB_PORTAL_SYSTEM.Api.Job_Provider
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "JobProvider")]
    public class ApplicationController : ControllerBase
    {
        private readonly IApplicationService _applicationService;

        public ApplicationController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        [HttpGet("company")]
        public async Task<IActionResult> GetApplicationsByCompany()
        {
            try
            {

                var companyIdClaim = User.FindFirst("CompanyId")?.Value;
                if (string.IsNullOrEmpty(companyIdClaim))
                {
                    return Unauthorized("CompanyId claim is missing or invalid");
                }
                var companyId = Guid.Parse(companyIdClaim);


                var applications = await _applicationService.GetApplicationsByCompanyAsync(companyId);

                return Ok(applications);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
