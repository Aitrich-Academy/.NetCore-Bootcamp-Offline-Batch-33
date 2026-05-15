using Domain.Data;
using Domain.Services.Admin.Location.Dto;
using Domain.Services.Admin.Location.Interface;
using Domain.Services.Admin.Login.Interface;
using Domain.Services.Admin.Logout.Interface;
using Domain.Services.Admin.Qualification.Dto;
using Domain.Services.Admin.Qualification.Interface;
using Domain.Services.Admin.Users.Interface;
using JOB_PORTAL_SYSTEM.Api.Admin.RequestObjects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JOB_PORTAL_SYSTEM.Api.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;
        private readonly IUserService _userService;
        private readonly ILocationRepository _locationRepository;
        private readonly IQualificationService _qualificationService;
        private readonly ILogoutService _logoutService;
        private readonly AppDbContext _context;
        public AdminController(IAdminService adminService, IUserService userService, ILocationRepository locationRepository, IQualificationService qualificationService, ILogoutService logoutService, AppDbContext context)
        {
            _adminService = adminService;
            _userService = userService;
            _locationRepository = locationRepository;
            _qualificationService = qualificationService;
            _logoutService = logoutService;
            _context = context;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(AdminLoginRequestDto dto)
        {
            try
            {
                var token = await _adminService.LoginAsync(dto.Email, dto.Password);

                return Ok(token);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("users")]
        public async Task<IActionResult> GetAllUsers()
        {
            try
            {
                var users = await _userService.GetAllUsersAsync();

                return Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("users/{id}")]
        public async Task<IActionResult> GetUserById(Guid id)
        {
            try
            {
                var user = await _userService.GetUserByIdAsync(id);

                if (user == null)
                {
                    return NotFound("User Not Found");
                }

                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("location")]
        public async Task<IActionResult> AddLocation(AddLocationDto dto)
        {
            try
            {
                var result = await _locationRepository
                    .AddLocationAsync(dto);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("qualification")]
        public async Task<IActionResult> AddQualification(AddQualificationDto dto)
        {
            try
            {
                var result = await _qualificationService.AddQualificationAsync(dto);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("logout")]

        public IActionResult Logout()
        {
            return Ok("Logged Out Successfully");
        }
        
    }
}