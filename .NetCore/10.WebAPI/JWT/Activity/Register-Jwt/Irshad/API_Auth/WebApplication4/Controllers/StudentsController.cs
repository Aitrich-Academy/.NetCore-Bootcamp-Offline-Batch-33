using API_Auth.DTO;
using API_Auth.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API_Auth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IUserService userService;

        public StudentsController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserDto dto)
        {
            var result = await userService.RegisterAsync(dto);
            if (result == null)
                return BadRequest(new { message = "Registration failed" });

            return Ok(new
            {
                message = "New User Added",
                user = result
            });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            var result = await userService.LoginAsync(dto);
            if (result == null)
                return Unauthorized(new { message = "Invalid credentials" });

            return Ok(new
            {
                message = "Login Success",
                user = result
            });
        }

        [HttpPost("JWTregister")]
        public async Task<IActionResult> Register(UserDto dto, [FromServices] IEmailService emailService)
        {
            var result = await userService.RegisterAsync(dto);
            if (result == null)
                return BadRequest("Registration failed");

            await emailService.SendEmailAsync(dto.Email, "Welcome!", "Thanks for registering with My API!");

            return Ok(new { message = "New User Added", user = result });
        }

    }
}
