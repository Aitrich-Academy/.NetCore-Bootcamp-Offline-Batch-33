using AutoMapper;
using Domain.Enums;
using Domain.Helper;
using Domain.Models;
using Domain.Services.Auth.DTO;
using Domain.Services.Auth.Interface;



namespace Domain.Services.Auth
{
    public class AuthService:IAuthService
    {
        private readonly IAuthRepository _repository;

        private readonly IMapper _mapper;

        private readonly IEmailService _emailService;

        private readonly IAuthRepository _authUser;


        public AuthService(
            IAuthRepository repository,
            IMapper mapper,
            IEmailService emailService,
            IAuthRepository authUser)
        {
            _repository = repository;
            _mapper = mapper;
            _emailService = emailService;
            _authUser = authUser;
        }

        public async Task<Guid> Signup(SignupRequestDTO dto)
        {
            var signupRequest = _mapper.Map<SignupRequest>(dto);

            var signupId =
                await _repository.AddSignupRequest(signupRequest);

            MailRequest mailRequest = new MailRequest
            {
                Subject = "Email Verification",
                Body =
                $"https://localhost:5001/api/auth/verify-email?signupId={signupId}",

                ToEmail = dto.Email
            };

            await _emailService.SendEmailAsync(mailRequest);

            return signupId;
        }

        public async Task<bool> VerifyEmail(Guid signupId)
        {
            var signup =
                await _repository.GetSignupRequest(signupId);

            if (signup == null)
                return false;

            signup.JobStatus = JobStatus.Verified;

            await _repository.UpdateSignupRequest(signup);

            return true;
        }

        public async Task<string> SetPassword(
            Guid signupId,
            PasswordDTO dto)
        {
            if (dto.Password != dto.ConfirmPassword)
                return "Password mismatch";

            var signup =
                await _repository.GetSignupRequest(signupId);

            if (signup == null)
                return "Signup request not found";

            if (signup.JobStatus != JobStatus.Verified)
                return "Email not verified";

            Guid userId = Guid.NewGuid();

            AuthUser authUser = new AuthUser
            {
                Id = userId,
                UserName = signup.UserName,
                FirstName = signup.FirstName,
                LastName = signup.LastName,
                Email = signup.Email,
                PhoneNumber = signup.Phone,

                Password =
                BCrypt.Net.BCrypt.HashPassword(dto.Password),

                Role = signup.Role
            };

            await _repository.AddAuthUser(authUser);

         

            if (signup.Role == Role.JobSeeker)
            {
               Models. JobSeeker seeker = new Models.JobSeeker
                {
                    Id = Guid.NewGuid(),
                    UserId = userId,
                    Username = signup.UserName,
                    FirstName = signup.FirstName,
                    LastName = signup.LastName,
                    Email = signup.Email,
                    Phone = signup.Phone,
                    Role = (int)Role.JobSeeker
                };

                await _repository.AddJobSeeker(seeker);
            }

        

            else if (signup.Role == Role.JobProvider)
            {
                JobProvider provider = new JobProvider
                {
                    Id = Guid.NewGuid(),
                    UserId = userId,
                    UserName = signup.UserName,
                    FirstName = signup.FirstName,
                    LastName = signup.LastName,
                    CreatedAt = DateTime.Now
                };

                await _repository.AddJobProvider(provider);
            }

            signup.JobStatus = JobStatus.Created;

            await _repository.UpdateSignupRequest(signup);

            return "Account Created Successfully";
        }

        public async Task<LoginDTO> Login(LoginRequestDTO dto)
        {
            var user =
                await _repository.GetUserByEmail(dto.Email);

            if (user == null)
                return null;

            bool isPasswordValid =
                BCrypt.Net.BCrypt.Verify(
                    dto.Password,
                    user.Password);

            if (!isPasswordValid)
                return null;

            var result = _mapper.Map<LoginDTO>(user);

            result.Token = _authUser.CreateToken(user);

          
            if (user.Role == Role.JobSeeker)
            {
                var seeker =
                    await _repository
                    .GetJobSeekerByUserId(user.Id);

                if (seeker != null)
                    result.JobSeekerId = seeker.Id;
            }

          

            if (user.Role == Role.JobProvider)
            {
                var provider =
                    await _repository
                    .GetJobProviderByUserId(user.Id);

                if (provider != null)
                    result.JobProviderId = provider.Id;
            }

            return result;
        }

        public async Task<string> ForgetPassword(
            ForgetPasswordDTO dto)
        {
            if (dto.NewPassword != dto.ConfirmPassword)
                return "Password mismatch";

            var user =
                await _repository.GetUserByEmail(dto.Email);

            if (user == null)
                return "User not found";

            user.Password =
                BCrypt.Net.BCrypt.HashPassword(dto.NewPassword);

            await _repository.UpdateUser(user);

            return "Password Updated Successfully";

        }
    }
}
