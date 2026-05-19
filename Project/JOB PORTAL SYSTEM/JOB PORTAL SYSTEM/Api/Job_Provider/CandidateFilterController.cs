using Domain.Services.Job_Provider.Candidate;
using Domain.Services.Job_Provider.Candidate.Dto;
using Domain.Services.Job_Provider.Candidate.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JOB_PORTAL_SYSTEM.Api.Job_Provider
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateFilterController : ControllerBase
    {
        private readonly ICandidateService _candidateService;

        public CandidateFilterController (ICandidateService candidateService )
        {
            _candidateService = candidateService;
        }

        [Authorize(Roles = "JobProvider,Company")]
        [HttpPost("filter")]
        public async Task<IActionResult> FilterCandidates(
            [FromBody] CandidateFilterRequest request)
        {
            var result =
                await _candidateService.FilterCandidatesAsync(request);

            return Ok(result);
        }
    }
}
