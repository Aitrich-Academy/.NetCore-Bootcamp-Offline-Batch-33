using AutoMapper;
using Domain;
using Domain.Interviews.Dto;
using Domain.Models;
using Domain.Services.Job_Provider.CompanyProfile.DTO;
using Domain.Services.Job_Provider.Job_Service.DTO;
using Domain.Services.Job_Provider.Login.Dto;
using Domain.Services.Job_Provider.Signup;
using Domain.Services.Job_Provider.Signup.Dto;
using Domain.Services.Job_Provider.Signup.Interface;
using Domain.Services.Job_Seeker.Login.DTO;
using Domain.Services.Job_Seeker.SignUp;
using Domain.Services.Job_Seeker.SignUp.DTO;
using Domain.Services.Job_Seeker.SignUp.Interface;
using JOB_PORTAL_SYSTEM.Api.Job_Provider.RequestObjects;
using JOB_PORTAL_SYSTEM.Api.Job_Seeker.RequestObjects;
using JOB_PORTAL_SYSTEM.API.Interviews.RequestObjects;
using JOB_PORTAL_SYSTEM.API.JobProvider.RequestObjects;

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

            CreateMap<IEmailService, EmailService>();
            CreateMap<Domain.Services.Job_Seeker.SignUp.Interface.ISignUpRequestService, Domain.Services.Job_Seeker.SignUp.SignUpRequestService>();
            


            CreateMap<CreateCompanyProfileRequest, Company>();
            CreateMap<UpdateCompanyProfileRequest, Company>();
            CreateMap<Company, CompanyProfileDto>()
                .ForMember(dest => dest.IndustryName, opt => opt.MapFrom(src => src.Industry != null ? src.Industry.Name : string.Empty))
                .ForMember(dest => dest.LocationName, opt => opt.MapFrom(src => src.Location != null ? src.Location.Name : string.Empty));



            CreateMap<AuthUser, JobProvider>().ReverseMap();

            CreateMap<Job, JobDto>()
                .ForMember(dest => dest.Company, opt => opt.MapFrom(src => src.Company != null ? src.Company.CompanyName : string.Empty))
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category != null ? src.Category.Name : string.Empty))
                .ForMember(dest => dest.Location, opt => opt.MapFrom(src => src.Location != null ? src.Location.Name : string.Empty));
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
