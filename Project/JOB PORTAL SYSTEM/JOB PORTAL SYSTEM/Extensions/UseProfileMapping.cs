using AutoMapper;
using Domain.Interviews.Dto;
using Domain.Models;
using Domain.Services.Job_Provider.CompanyProfile.DTO;
using Domain.Services.Job_Provider.Job_Service.DTO;
<<<<<<< HEAD
using Domain.Services.Job_Seeker.Login.DTO;
using Domain.Services.Job_Seeker.SignUp.DTO;
using JOB_PORTAL_SYSTEM.Api.Job_Provider.RequestObjects;
using JOB_PORTAL_SYSTEM.Api.Job_Seeker.RequestObjects;
=======
using Domain.Services.Login.Dto;
using Domain.Services.Signup.Dto;
using JOB_PORTAL_SYSTEM.Api.Job_Provider.RequestObjects;
using JOB_PORTAL_SYSTEM.API.Interviews.RequestObjects;
using JOB_PORTAL_SYSTEM.API.JobProvider.RequestObjects;
>>>>>>> d368a2d9021872ac3c7470e4c0208f4720a40b51

namespace JOB_PORTAL_SYSTEM.Extensions
{
    public class UseProfileMapping : Profile
    {
        public UseProfileMapping()
        {
<<<<<<< HEAD
            CreateMap<JobSeekerSignUpRequest, JobSeekerRequestDTO>().ReverseMap();

            CreateMap<JobSeekerRequestDTO, SignupRequest>().ReverseMap();

            CreateMap<AuthUser, LoginrequestDto>().ReverseMap();

            CreateMap<Domain.Services.Job_Provider.CompanyProfile.DTO.CreateCompanyProfileRequest, Company>();
=======
            CreateMap<CreateCompanyProfileRequest, Company>();
>>>>>>> d368a2d9021872ac3c7470e4c0208f4720a40b51
            CreateMap<UpdateCompanyProfileRequest, Company>();
            CreateMap<Company, CompanyProfileDto>();
            CreateMap<AuthUser, JobProvider>().ReverseMap();

            CreateMap<Job, JobDto>();
            CreateMap<CreateJobDto, Job>();
            CreateMap<UpdateJobDto, Job>();

            CreateMap<JobProviderSignupRequestDto, SignupRequest>().ReverseMap();
            CreateMap<JobProviderSignupRequest, JobProviderSignupRequestDto>().ReverseMap();
            CreateMap<AuthUser, JobProvider>().ReverseMap();
            CreateMap<AuthUser, JobproviderLoginDto>();
            CreateMap<CreateInterviewDto, Interview>().ReverseMap();
            CreateMap<Interview, InterviewResponseDto>().ReverseMap();
            CreateMap<CreateInterviewRequest, CreateInterviewDto>();
        }
    }
}
