using Domain.Services.Member.DTO;
using Domain.Services.Member.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JOB_PORTAL_SYSTEM.Api.Job_ProviderModule
{

    [ApiController]
    [Route("api/providers/members")]
    [Authorize(Roles = "JobProvider")]
    public class CompanyMemberController : ControllerBase
    {
        private readonly IMemberService _service;

        public CompanyMemberController(IMemberService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateMemberDto dto)
        {
            var companyIdClaim = User.FindFirst("CompanyId")?.Value;
            if (string.IsNullOrEmpty(companyIdClaim))
                return Unauthorized();

            var loggedInCompanyId = Guid.Parse(companyIdClaim);

            // enforce ownership: inject CompanyId from JWT
            dto.CompanyId = loggedInCompanyId;


            var result = await _service.CreateAsync(dto);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var companyIdClaim = User.FindFirst("CompanyId")?.Value;
            if (string.IsNullOrEmpty(companyIdClaim))
                return Unauthorized();

            var loggedInCompanyId = Guid.Parse(companyIdClaim);

            var member = await _service.GetByIdAsync(id);
            if (member == null)
                return NotFound();

            if (member.CompanyId != loggedInCompanyId)
                return Forbid();


            
            return Ok(member);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var companyIdClaim = User.FindFirst("CompanyId")?.Value;
            if (string.IsNullOrEmpty(companyIdClaim))
                return Unauthorized();

            var loggedInCompanyId = Guid.Parse(companyIdClaim);

            var result = await _service.GetAllAsync(loggedInCompanyId);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, UpdateCompanyMemberDto dto)
        {
            var companyIdClaim = User.FindFirst("CompanyId")?.Value;
            if (string.IsNullOrEmpty(companyIdClaim)) 
                return Unauthorized();

            var loggedInCompanyId = Guid.Parse(companyIdClaim);

            var member = await _service.GetByIdAsync(id);
            if (member == null) 
                return NotFound();

            if (member.CompanyId != loggedInCompanyId) 
                return Forbid();


            var result = await _service.UpdateAsync(id, dto);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("{id}")]    
        public async Task<IActionResult> Delete(Guid id)
        {
            var companyIdClaim = User.FindFirst("CompanyId")?.Value;
            if (string.IsNullOrEmpty(companyIdClaim))
                return Unauthorized();

            var loggedInCompanyId = Guid.Parse(companyIdClaim);

            var member = await _service.GetByIdAsync(id);
            if (member == null)
                return NotFound();

            if (member.CompanyId != loggedInCompanyId)
                return Forbid();

            var deleted = await _service.DeleteAsync(id);

            if (!deleted)
                return NotFound();

            return Ok("Deleted Successfully");
        }

    }
}



