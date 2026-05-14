using AutoMapper;
using Domain.Models;
using Domain.Service.Login.DTO;
using Domain.Service.SignUp.DTO;
using Domain.Services.Admin.CompanyVerification.Dto;
using Domain.Services.Admin.Skills.Dto;
using Domain.Services.Job_Provider.CompanyProfile.DTO;
using Domain.Services.Job_Provider.Job_Service.DTO;
using JOB_PORTAL_SYSTEM.Api.ADMIN.RequestObjects;
using JOB_PORTAL_SYSTEM.Api.Job_Provider.RequestObjects;
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

            CreateMap<Job, JobStatsDto>().ReverseMap();
            CreateMap<JobStatsDto, JobStatsRequest>().ReverseMap();

            CreateMap<Skill, AddSkillDto>().ReverseMap();
            CreateMap<AddSkillDto, AddSkillRequest>().ReverseMap();

            CreateMap<Skill, UpdateSkillDto>().ReverseMap();
            CreateMap<UpdateSkillDto, UpdateSkillRequest>().ReverseMap();

            CreateMap<Skill, DeleteSkillDto>().ReverseMap();
            CreateMap<DeleteSkillDto, DeleteSkillRequest>().ReverseMap();
        }
    }
}
