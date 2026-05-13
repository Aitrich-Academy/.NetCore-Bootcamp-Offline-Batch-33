using AutoMapper;
using Domain.Data;
using Domain.Services.AuthUser.Interface;
using Domain.Services.Login.Dto;
using Domain.Services.Login.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Login
{
    public class LoginRequestService : ILoginRequestService
    {
        private readonly ILoginRequestRepository _jobproviderRepository;
        private readonly IMapper _mapper;
        private readonly IAuthUserRepository _authUserRepository;
        private readonly AppDbContext _context;

        public LoginRequestService(ILoginRequestRepository jobSeekerRepository, IMapper mapper, IAuthUserRepository authUserRepository, AppDbContext context )
        {
            _jobproviderRepository = jobSeekerRepository;
            _mapper = mapper;
            _authUserRepository = authUserRepository;
            _context = context;
        }
        public JobproviderLoginDto login(string email, string password)
        {
            var user = _jobproviderRepository.GetUserByEmail(email);
            if (user == null)
            {
                return null;
            }
            else
            {
                if (BCrypt.Net.BCrypt.Verify(password, user.Password))
                {
                    var jobProvider = _context.JobProviders.FirstOrDefault(x => x.UserId == user.Id);

                    var userReturn = _mapper.Map<JobproviderLoginDto>(user);
                    userReturn.Token = _authUserRepository.CreateToken(user);
                    if (jobProvider != null)
                    {
                        userReturn.JobProviderId = jobProvider.Id;
                    }
                    return userReturn;
                }
                return null;
            }
        }
    }
}
