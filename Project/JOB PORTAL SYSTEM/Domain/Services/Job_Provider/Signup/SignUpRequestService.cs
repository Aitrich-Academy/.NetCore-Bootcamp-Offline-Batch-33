using AutoMapper;
using AutoMapper.Internal;
using Domain.Data;
using Domain.Helper;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using Domain.Services.Job_Provider.Signup.Dto;
using Domain.Services.Job_Provider.Signup.Interface;
using Domain.Services.Job_Provider.AuthUser.Interface;

namespace Domain.Services.Job_Provider.Signup
{
    public class SignUpRequestService : ISignUpRequestService
    {
        private readonly ISignUpRequestRepository _signUpRequestRepository;
        private readonly IAuthUserRepository _authUserRepository;
        private readonly IMapper _mapper;
        private readonly AppDbContext _context;
        private readonly IEmailService _emailService;
        public SignUpRequestService(ISignUpRequestRepository signUpRequestRepository, IAuthUserRepository authUserRepository, IMapper mapper, AppDbContext context, IEmailService emailService)
        {
            _signUpRequestRepository = signUpRequestRepository;
            _authUserRepository = authUserRepository;
            _mapper = mapper;
            _context = context;
            _emailService = emailService;
        }

        public async Task CreateJobprovider(Guid jobproviderSignupRequestId, string password)
        {
            try
            {
                SignupRequest signupRequest =
                    await _signUpRequestRepository
                    .GetSignupRequestByIdAsync(jobproviderSignupRequestId);

                if (signupRequest == null)
                    throw new Exception("Signup request not found");

                if (signupRequest.JobStatus != Enums.JobStatus.Verified)
                    throw new Exception("Email not verified");

                // Create User Id
                Guid userId = Guid.NewGuid();

                // Create Auth User
                Models.AuthUser authUser = new Models.AuthUser
                {
                    Id = userId,
                    UserName = signupRequest.UserName,
                    FirstName = signupRequest.FirstName,
                    LastName = signupRequest.LastName,
                    Email = signupRequest.Email,
                    Password = BCrypt.Net.BCrypt.HashPassword(password),
                    PhoneNumber = signupRequest.Phone,
                    Role = Enums.Role.JobProvider
                };

                await _authUserRepository.AddAuthUser(authUser);

                // Create Job Provider
                JobProvider jobprovider = new JobProvider
                {
                    Id = Guid.NewGuid(),
                    UserId = userId,
                    UserName = signupRequest.UserName,
                    FirstName = signupRequest.FirstName,
                    LastName = signupRequest.LastName,

                    // if available+

                    CompanyId = signupRequest.CompanyId,

                    CreatedAt = DateTime.Now
                };

                await _context.JobProviders.AddAsync(jobprovider);

                // Update signup status
                signupRequest.JobStatus = Enums.JobStatus.Created;

                _signUpRequestRepository.UpdateSignupRequest(signupRequest);

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }


        public async Task<Guid> CreateSignupRequest(JobProviderSignupRequestDto data)
        {
            var signupRequest = _mapper.Map<SignupRequest>(data);
            var signUpId = _signUpRequestRepository.AddSignupRequest(signupRequest);
            MailRequest mailRequest = new MailRequest();
            mailRequest.Subject = "HireMeNow JobProvider SignUp Verification";
            mailRequest.Body = "http://localhost:7197/set-password?signupid=" + signUpId.ToString();
            mailRequest.ToEmail = signupRequest.Email;
            await _emailService.SendEmailAsync(mailRequest);
            return signUpId;
        }


        public async  Task<bool> VerifyEmailAsync(Guid jobproviderSignupRequestId)
        {
            SignupRequest signupRequest = await _signUpRequestRepository.GetSignupRequestByIdAsync(jobproviderSignupRequestId);
            if (signupRequest != null)
            {
                signupRequest.JobStatus = Enums.JobStatus.Verified;
                _signUpRequestRepository.UpdateSignupRequest(signupRequest);
                return true;
            }
            return false;
        }
    }
}
