using AutoMapper;
using Domain.Service.Authuser.Interfaces;
using Domain.Service.Login.DTOs;
using Domain.Service.Login.Interfaces;


namespace Domain.Service.Login
{
    public class LoginRequestService : ILoginRequestService
    {
        ILoginRequestRepository jobSeekerRepository;
        IAuthUserRepository authUserRepository;
        IMapper mapper;
        public LoginRequestService(ILoginRequestRepository _jobSeekerRepository, IMapper _mapper, IAuthUserRepository _authUserRepository)
        {
            jobSeekerRepository = _jobSeekerRepository;
            mapper = _mapper;
            
            authUserRepository = _authUserRepository;
        }

        public JobSeekerLoginDto login(string email, string password)
        {
            var user = jobSeekerRepository.GetUserByEmailpassword(email,password);
            if (user == null)
            {
                return null;
            }
            else
            {
                if ((password == user.Password))
                {
                    var userReturn = mapper.Map<JobSeekerLoginDto>(user);
                    userReturn.Token = authUserRepository.CreateToken(user);
                    return userReturn;
                }
                return null;
            }
           
        }

     
    }
       
    }

