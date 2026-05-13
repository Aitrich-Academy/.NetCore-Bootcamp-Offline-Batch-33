using AutoMapper;
using Domain.Services.Job_Provider.Login.Interface;
using Domain.Services.Job_Provider.Signup.Dto;
using Domain.Services.Job_Provider.Signup.Interface;
using JOB_PORTAL_SYSTEM.API.JobProvider.RequestObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JOB_PORTAL_SYSTEM.API.JobProvider
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobProviderController : ControllerBase
    {
        private readonly ISignUpRequestService _signUpRequestService;
        private readonly IMapper _mapper;
        private readonly ILoginRequestService _loginRequestService;

            public JobProviderController(ISignUpRequestService signUpRequestService, IMapper mapper, ILoginRequestService loginRequestService )
            {
                _signUpRequestService = signUpRequestService;
                _mapper = mapper;
                _loginRequestService = loginRequestService;
            }


            [HttpPost]
            [Route("job-provider/signup")]
            public async Task<ActionResult> CreateJobProviderSignupRequest(JobProviderSignupRequest data)
            {
                var jobSeekerSignupRequest = _mapper.Map<JobProviderSignupRequestDto>(data);
                var signupId = await _signUpRequestService.CreateSignupRequest(jobSeekerSignupRequest);

                return Ok(signupId);
            }


        [HttpGet]
        [Route("job-provider/signup/{JobproviderSignupRequestId}/verify-email")]
        public async Task<ActionResult> VerifyJobSeeekerEmail(Guid JobproviderSignupRequestId)
        {
            var isVerifed = await _signUpRequestService.VerifyEmailAsync(JobproviderSignupRequestId);
            if (isVerifed)
            {
                return Ok("Signup request verified successfully");
            }
            return BadRequest("Signup request verification failed");
        }


        [HttpPost]
        [Route("job-provider/signup/{id}/set-password")]
        public async Task<IActionResult> createJobproviderSignupRequest(Guid id, string password)
        {
            try
            {
                await _signUpRequestService.CreateJobprovider(id, password);
                return Ok("Password set successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        [Route("job-provider/login")]
        public async Task<ActionResult> Login(JobproviderLoginRequest logdata)
        {
            var user = _loginRequestService.login(logdata.Email, logdata.Password);

            if (user == null)
            {
                return BadRequest("Login Failed");
            }
            return Ok(user);
        }


       
    }
}
