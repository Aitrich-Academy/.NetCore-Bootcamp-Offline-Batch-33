using AutoMapper;
using Domain.Models;
using Domain.Services.Job_Provider.Job_Service.DTO;
using Domain.Services.Job_Seeker.Interviews.DTOs;
using Domain.Services.Job_Seeker.SignUp.DTO;
using Domain.Services.Job_Seeker.Applications.DTOs;
using Domain.Services.Job_Seeker.Login.DTO;
using Domain.Services.Job_Seeker.SavedJobs.DTOs;
using Domain.Services.Job_Seeker.Jobs.DTOs;
using JOB_PORTAL_SYSTEM.Api.Job_Seeker.RequestObjects;

namespace JOB_PORTAL_SYSTEM.Extensions
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<JobSeekerSignUpRequest, JobSeekerRequestDTO>().ReverseMap();

            CreateMap<JobSeekerRequestDTO, SignupRequest>().ReverseMap();

            CreateMap<AuthUser, LoginrequestDto>().ReverseMap();

            CreateMap<ApplyJobDto, JobApplication>();

            CreateMap<JobApplication, MyApplicationDto>()
                .ForMember(dest => dest.JobId,
                    opt => opt.MapFrom(src => src.JobId))

                .ForMember(dest => dest.JobTitle,
                    opt => opt.MapFrom(src => src.Job != null ? src.Job.Title : string.Empty))

                .ForMember(dest => dest.CompanyName,
                    opt => opt.MapFrom(src =>
                        src.Job != null && src.Job.Company != null
                            ? src.Job.Company.CompanyName
                            : string.Empty))

                .ForMember(dest => dest.Status,
                    opt => opt.MapFrom(src => src.Status.ToString()))

                .ForMember(dest => dest.AppliedDate,
                    opt => opt.MapFrom(src => src.AppliedDate));

            CreateMap<Interview, InterviewDto>()
                .ForMember(dest => dest.JobTitle,
                    opt => opt.MapFrom(src =>
                        src.Application != null && src.Application.Job != null
                            ? src.Application.Job.Title
                            : string.Empty))

                .ForMember(dest => dest.Mode,
                    opt => opt.MapFrom(src => src.Mode.ToString()))

                .ForMember(dest => dest.Status,
                    opt => opt.MapFrom(src => src.Status.ToString()))

                .ForMember(dest => dest.InterviewDate,
                    opt => opt.MapFrom(src => src.InterviewDate));

            CreateMap<Job, GetJobsDto>()
               .ForMember(dest => dest.Id,
                   opt => opt.MapFrom(src => src.Id))

               .ForMember(dest => dest.Title,
                   opt => opt.MapFrom(src => src.Title))

               .ForMember(dest => dest.CompanyName,
                   opt => opt.MapFrom(src =>
                       src.Company != null ? src.Company.CompanyName : string.Empty))

               .ForMember(dest => dest.Location,
                   opt => opt.MapFrom(src =>
                       src.Location != null ? src.Location.Name : string.Empty))

               .ForMember(dest => dest.Salary,
                   opt => opt.MapFrom(src => src.Salary));

            CreateMap<SavedJob, SavedJobsResponseDto>()
                .ForMember(dest => dest.JobTitle,
                opt => opt.MapFrom(src => src.Job.Title))

                .ForMember(dest => dest.CompanyName,
                opt => opt.MapFrom(src => src.Job.Company.CompanyName))

                .ForMember(dest => dest.Location,
                opt => opt.MapFrom(src => src.Job.Location.Name));
        }
    }
}
