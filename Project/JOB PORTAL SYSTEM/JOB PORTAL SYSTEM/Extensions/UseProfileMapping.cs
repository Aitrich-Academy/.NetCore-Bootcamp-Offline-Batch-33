using AutoMapper;
using Domain.Services.Job_Provider.Interviews.Dto;
using Domain.Models;
using Domain.Services.Job_Provider.CompanyProfile.DTO;
using Domain.Services.Job_Provider.Job_Service.DTO;
using JOB_PORTAL_SYSTEM.Api.Job_Provider.RequestObjects;
using JOB_PORTAL_SYSTEM.API.Interviews.RequestObjects;



namespace JOB_PORTAL_SYSTEM.Extensions
{
    public class UseProfileMapping : Profile
    {
        public UseProfileMapping()
        {
            CreateMap<CreateCompanyProfileRequestDTO, Company>();
            CreateMap<UpdateCompanyProfileRequestDTO, Company>();
            CreateMap<Company, CompanyProfileDto>();
            CreateMap<AuthUser, JobProvider>().ReverseMap();

            CreateMap<Job, JobDto>();
            CreateMap<CreateJobDto, Job>();
            CreateMap<UpdateJobDto, Job>();

            //CreateMap<Domain.JobProviderSignupRequestDto, SignupRequest>().ReverseMap();
            //CreateMap<JobProviderSignupRequest, JobProviderSignupRequestDto>().ReverseMap();
            CreateMap<AuthUser, JobProvider>().ReverseMap();
            //CreateMap<AuthUser, JobproviderLoginDto>();
            CreateMap<CreateInterviewDto, Interview>().ReverseMap();
            CreateMap<Interview, InterviewResponseDto>().ReverseMap();
            CreateMap<CreateInterviewRequest, CreateInterviewDto>();
        }
    }
}
