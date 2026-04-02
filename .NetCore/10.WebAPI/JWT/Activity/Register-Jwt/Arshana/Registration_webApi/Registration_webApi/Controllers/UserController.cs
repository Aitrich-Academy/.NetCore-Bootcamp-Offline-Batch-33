using Microsoft.AspNetCore.Mvc;
using Registration_webApi.Dto;
using Registration_webApi.Interface;

namespace Registration_webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpPost("register")]
        public IActionResult AddUser(RegistrationDto registerDto)
        {
            _service.RegisterUserAsync(registerDto);
            return Ok("Added Successfully");
        }

        [HttpPost("login")]
        public IActionResult Login(LoginDto loginDto)
        {
            var user = _service.LoginAsync(loginDto);
            return Ok("LoggedIn Successfully");
        }

    }
}
