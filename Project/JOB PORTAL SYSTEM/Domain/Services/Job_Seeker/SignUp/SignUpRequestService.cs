using AutoMapper;
using Domain.Enums;
using Domain.Helpers;
using Domain.Models;
using Domain.Services.Job_Seeker.AuthUser.Interface;
using Domain.Services.Job_Seeker.SignUp.DTO;
using Domain.Services.Job_Seeker.SignUp.Interface;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Job_Seeker.SignUp
{
    public class SignUpRequestService : ISignUpRequestService
    {
        ISignUpRequestRepository _signUp;
        IAuthUserRepository _authuser;
        IMapper _mapper;
        IEmailService _emailService;

        public SignUpRequestService(ISignUpRequestRepository signUp, IMapper mapper, IEmailService emailService, IAuthUserRepository authuser)
        {
            _signUp = signUp;
            _mapper = mapper;
            _emailService = emailService;
            _authuser = authuser;
        }
        public async Task CreateJobseeker(Guid jobSeekerSignupRequestId, string password)
        {
            try
            {
                var signUpRequest = await _signUp
                    .GetSignupRequestByIdAsync(jobSeekerSignupRequestId);

                if (signUpRequest == null)
                    throw new Exception("Signup request not found");

                if (signUpRequest.JobStatus != JobStatus.Verified)
                    return;

                var userId = Guid.NewGuid();


                var authUser = new Models.AuthUser
                {
                    Id = userId,
                    UserName = signUpRequest.UserName,
                    FirstName = signUpRequest.FirstName,
                    LastName = signUpRequest.LastName,
                    Email = signUpRequest.Email,
                    PhoneNumber = signUpRequest.Phone,
                    Password = password,
                    Role = Role.JobSeeker
                };

                await _authuser.AddAuthUser(authUser);

                var jobSeeker = new JobSeeker
                {
                    Id = Guid.NewGuid(),
                    UserId = userId,
                    Username = signUpRequest.UserName,
                    FirstName = signUpRequest.FirstName,
                    LastName = signUpRequest.LastName,
                    Email = signUpRequest.Email,
                    Phone = signUpRequest.Phone,
                    Role = (int)Role.JobSeeker
                };

                await _signUp.AddJobSeekerAsync(jobSeeker);

                signUpRequest.JobStatus = JobStatus.Created;
                await _signUp.UpdateSignUpRequest(signUpRequest);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public async Task<Guid> CreateSignupRequest(JobSeekerRequestDTO data)
        {


            var signUpRequest = _mapper.Map<SignupRequest>(data);
            var signUpId = await _signUp.AddSignUpRequest(signUpRequest);



            MailRequest mailRequest = new MailRequest
            {
                Subject = "HireMeNow SignUp Verification",
                Body = $"https://localhost:5001/job-seeker/verify?signupId={signUpId}",
                ToEmail = signUpRequest.Email
            };

            await _emailService.SendEmailAsync(mailRequest);
            return signUpId;
        }
        public async Task<bool> VerifyEmailAsync(Guid jobSeekerSignupRequestId)
        {

            SignupRequest signUpRequest = await _signUp.GetSignupRequestByIdAsync(jobSeekerSignupRequestId);
            if (signUpRequest != null)
            {
                signUpRequest.JobStatus = JobStatus.Verified;
                await _signUp.UpdateSignUpRequest(signUpRequest);
                return true;
            }
            return false;
        }
    }


}

