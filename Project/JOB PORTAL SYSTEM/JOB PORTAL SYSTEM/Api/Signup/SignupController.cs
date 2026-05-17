using Domain.Services.Auth.Interface;
using Domain.Services.Auth.DTO;
using Microsoft.AspNetCore.Mvc;
using Domain.Services.Job_Provider.Login.Dto;

namespace JOB_PORTAL_SYSTEM.Api.Signup
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignupController : ControllerBase
    {

        private readonly IAuthService _service;

        public SignupController(IAuthService service)
        {
            _service = service;
        }

       

        [HttpPost("signup")]
        public async Task<IActionResult> Signup(
            SignupRequestDTO dto)
        {
            try
            {
                var id = await _service.Signup(dto);

                return Ok(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    

        [HttpGet("verify-email")]
        public async Task<IActionResult> VerifyEmail(
            Guid signupId)
        {
            try
            {
                var result =
                    await _service.VerifyEmail(signupId);

                if (!result)
                    return BadRequest(
                        "Verification failed");

                return Ok("Email Verified");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost("set-password/{signupId}")]
        public async Task<IActionResult> SetPassword(
            Guid signupId,
            PasswordDTO dto)
        {
            try
            {

                var result =
                    await _service.SetPassword(
                        signupId,
                        dto);

                if (result !=
                    "Account Created Successfully")
                {
                    return BadRequest(result);
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

       

        [HttpPost("login")]
        public async Task<IActionResult> Login(
            LoginRequestDTO dto)
        {
            try
            {
                var result =
                    await _service.Login(dto);

                if (result == null)
                    return BadRequest(
                        "Invalid credentials");

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        [HttpPost("forget-password")]
        public async Task<IActionResult> ForgetPassword(
            ForgetPasswordDTO dto)
        {
            try
            {
                var result =
                    await _service.ForgetPassword(dto);

                if (result !=
                    "Password Updated Successfully")
                {
                    return BadRequest(result);
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
  }     }
}
