using AutoMapper;
using Domain.Models;
using Domain.Services.Auth.DTO;
using Domain.Services.Job_Provider.Candidate.Dto;
using Domain.Services.Job_Provider.Job_Service.DTO;
using Domain.Services.Job_Provider.ViewCompanyApplications.Dto;
using Domain.Services.Job_Provider.ViewJobs.Dto;
using Domain.Services.Job_Seeker.Applications.DTOs;
using Domain.Services.Job_Seeker.Interviews.DTOs;
using Domain.Services.Job_Seeker.SavedJobs.DTOs;
using Domain.Services.Jobs.DTOs;


namespace JOB_PORTAL_SYSTEM.Extensions
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AuthUser, LoginDTO>().ReverseMap();

            CreateMap<SignupRequestDTO, SignupRequest>().ReverseMap();

            CreateMap<AuthUser, LoginRequestDTO>().ReverseMap();

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


            CreateMap<JobSeeker, CandidateDto>()
                .ForMember(dest => dest.CandidateId,
                opt => opt.MapFrom(src => src.Id))

                .ForMember(dest => dest.CandidateName,
                opt => opt.MapFrom(src =>
                    src.FirstName + " " + src.LastName))

                .ForMember(dest => dest.ProfileName,
                opt => opt.MapFrom(src => src.Profile.ProfileName))

                .ForMember(dest => dest.ProfileDescription,
                opt => opt.MapFrom(src => src.Profile.ProfileDescription))

                .ForMember(dest => dest.Experience,
                opt => opt.MapFrom(src => src.Profile.Experience));


            CreateMap<Job, ViewCompanyJobDto>()
                .ForMember(dest => dest.JobId,
                opt => opt.MapFrom(src => src.Id))

                .ForMember(dest => dest.CategoryName,
                opt => opt.MapFrom(src => src.Category.Name))

                .ForMember(dest => dest.LocationName,
                opt => opt.MapFrom(src => src.Location.Name));

            CreateMap<JobApplication, CompanyApplicationDto>()
    .ForMember(dest => dest.ApplicationId,
        opt => opt.MapFrom(src => src.Id))

    .ForMember(dest => dest.JobTitle,
        opt => opt.MapFrom(src => src.Job.Title))

    .ForMember(dest => dest.CandidateName,
        opt => opt.MapFrom(src =>
            src.JobSeeker.FirstName + " " + src.JobSeeker.LastName));
        }
    }
}
