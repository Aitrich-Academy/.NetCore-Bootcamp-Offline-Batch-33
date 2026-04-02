using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Registration_webApi.Dto;
using Registration_webApi.Service;

namespace Registration_webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        private readonly EmailService _emailService;

        public MailController(EmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost("send")]
        public async Task<IActionResult> SendMail([FromBody] EmailDto request)
        {
            await _emailService.SendEmailAsync(
                request.ToEmail,
                request.Subject,
                request.Body
            );

            return Ok("Email Sent Successfully");
        }
    }
}