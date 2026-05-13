using AutoMapper;
using Domain.Services.Job_Seeker.Login.DTO;
using Domain.Services.Job_Seeker.Login.Interface;
using Domain.Services.Job_Seeker.SignUp.DTO;
using Domain.Services.Job_Seeker.SignUp.Interface;
using JOB_PORTAL_SYSTEM.Api.Job_Seeker.RequestObjects;

using Microsoft.AspNetCore.Mvc;

namespace JOB_PORTAL_SYSTEM.Api.Job_Seeker
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobSeekerController : ControllerBase
    {
        private readonly ISignUpRequestService _Signupservice;
        private readonly ILoginRequestServices _loginService;
        private readonly IMapper _mapper;
        public JobSeekerController(ISignUpRequestService Signupservice, IMapper mapper, ILoginRequestServices loginService)
        {
            _Signupservice = Signupservice;
            _loginService = loginService;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("Jobseeker/signup")]
        public async Task<IActionResult> CreateSignUpRequest(
       JobSeekerRequestDTO jobSeekerRequestDTO)
        {
            try
            {
                var signupId = await _Signupservice
                    .CreateSignupRequest(jobSeekerRequestDTO);

                return Ok(signupId);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("/auth/jobSeeker-auth/verify-email")]
        public async Task<IActionResult> SignuprequestVerify([FromQuery] Guid jobseekersignuprequestId)
        {
            try
            {
                var isVerified = await _Signupservice
                    .VerifyEmailAsync(jobseekersignuprequestId);

                if (isVerified)
                    return Ok("Signup Request is verified successfully");

                return BadRequest("Signup request verification Failed");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("job-seeker/signup/{jobSeekerSignupRequestId}/set-password")]
        public async Task<IActionResult> CreateJobSeekerSignupRequest(
      Guid jobSeekerSignupRequestId,
      [FromBody] PasswordDTO passwordDTO)
        {
            try
            {
                if (jobSeekerSignupRequestId == Guid.Empty)
                    return BadRequest("Invalid signup request ID");

                if (passwordDTO == null || string.IsNullOrWhiteSpace(passwordDTO.Password))
                    return BadRequest("Password is required");

                if (passwordDTO.Password != passwordDTO.ConfirmPassword)
                    return BadRequest("Passwords do not match");

                await _Signupservice.CreateJobseeker(
                    jobSeekerSignupRequestId,
                    passwordDTO.Password);

                return Ok("Jobseeker created successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("jobseeker/login")]
        public async Task<IActionResult> Login(JobSeekerLoginRequest logdata)
        {
            try
            {
                var user = _loginService.Login(logdata.Email, logdata.Password);

                if (user == null)
                {
                    return BadRequest("Invalid email or password");
                }

                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        [Route("jobseeker/forgetpassword")]
        public async Task<IActionResult> Forgetpassword(ForgetPasswordDTO dto)
        {
            try
            {
                var result = await _loginService.ForgetPassword(dto);

                if (result != "Password Updated Successfully")
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
    }
}
