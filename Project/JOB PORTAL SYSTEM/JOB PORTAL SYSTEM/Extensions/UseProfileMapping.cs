using AutoMapper;
using Domain.Models;
using Domain.Services.Job_Provider.CompanyProfile.DTO;
using Domain.Services.Job_Provider.Job_Service.DTO;
using Domain.Services.Job_Seeker.Login.DTO;
using Domain.Services.Job_Seeker.SignUp.DTO;
using JOB_PORTAL_SYSTEM.Api.Job_Provider.RequestObjects;
using JOB_PORTAL_SYSTEM.Api.Job_Seeker.RequestObjects;

namespace JOB_PORTAL_SYSTEM.Extensions
{
    public class UseProfileMapping : Profile
    {
        public UseProfileMapping()
        {
            CreateMap<JobSeekerSignUpRequest, JobSeekerRequestDTO>().ReverseMap();

            CreateMap<JobSeekerRequestDTO, SignupRequest>().ReverseMap();

            CreateMap<AuthUser, LoginrequestDto>().ReverseMap();

            CreateMap<Domain.Services.Job_Provider.CompanyProfile.DTO.CreateCompanyProfileRequest, Company>();
            CreateMap<UpdateCompanyProfileRequest, Company>();
            CreateMap<Company, CompanyProfileDto>();
            CreateMap<AuthUser, JobProvider>().ReverseMap();

            CreateMap<Job, JobDto>();
            CreateMap<CreateJobDto, Job>();
            CreateMap<UpdateJobDto, Job>();
        }
    }
}
