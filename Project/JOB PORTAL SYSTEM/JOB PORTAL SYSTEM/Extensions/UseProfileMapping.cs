using AutoMapper;
using Domain.Models;
using Domain.Services.Admin.CompanyVerification.Dto;
using Domain.Services.Admin.Skills.Dto;
using Domain.Services.Job_Provider.CompanyProfile.DTO;
using Domain.Services.Job_Provider.Job_Service.DTO;
using JOB_PORTAL_SYSTEM.Api.ADMIN.RequestObjects;
using JOB_PORTAL_SYSTEM.Api.Job_Provider.RequestObjects;
using JOB_PORTAL_SYSTEM.Api.JobSeeker.RequestObjects;

namespace JOB_PORTAL_SYSTEM.Extensions
{
    public class UseProfileMapping : Profile
    {
        public UseProfileMapping()
        {
            CreateMap<CreateCompanyProfileRequest, Company>();
            CreateMap<UpdateCompanyProfileRequest, Company>();
            CreateMap<Company, CompanyProfileDto>();
            CreateMap<AuthUser, JobProvider>().ReverseMap();

            CreateMap<Job, JobDto>();
            CreateMap<CreateJobDto, Job>();
            CreateMap<UpdateJobDto, Job>();

            CreateMap<Company, VerifyCompanyDto>().ReverseMap();
            CreateMap<VerifyCompanyDto, VerifyCompanyRequest>().ReverseMap();
            CreateMap<Company, CompanyProfilesDto>().ReverseMap();
            CreateMap<CompanyProfilesDto, CompanyProfileRequest>().ReverseMap();

            CreateMap<Job , JobStatsDto>().ReverseMap();
            CreateMap<JobStatsDto , JobStatsRequest>().ReverseMap();

            CreateMap<Skill, AddSkillDto>().ReverseMap();
            CreateMap<AddSkillDto , AddSkillRequest>().ReverseMap();
        }
    }
}
