using Domain.Member.DTO;
using Domain.Member.Interface;
using Microsoft.AspNetCore.Mvc;

namespace JOB_PORTAL_SYSTEM.Api.Job_Provider_Module
{
    [ApiController]
    [Route("api/applications")]
    public class ApplicationController : ControllerBase
    {
        private readonly IApplicationservice _service;

        public ApplicationController(IApplicationservice service)
        {
            _service = service;
        }

        [HttpPut("{id}/status")]
        public async Task<IActionResult> UpdateStatus(Guid id, UpdateApplicationStatus dto)
        {
            var result = await _service.UpdateStatusAsync(id, dto);

            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}