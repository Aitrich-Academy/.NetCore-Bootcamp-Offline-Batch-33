using AutoMapper;
using Domain.Models;
using Domain.Service.Login.DTO;
using Domain.Service.SignUp.DTO;
using JOB_PORTAL_SYSTEM.API.JobSeeker.RequestObjects;

namespace JOB_PORTAL_SYSTEM.Extensions
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<JobSeekerSignUpRequest, JobSeekerRequestDTO>().ReverseMap();
            CreateMap<JobSeekerRequestDTO, SignupRequest>().ReverseMap();
            CreateMap<AuthUser, LoginrequestDto>().ReverseMap();

        }
    }
}
