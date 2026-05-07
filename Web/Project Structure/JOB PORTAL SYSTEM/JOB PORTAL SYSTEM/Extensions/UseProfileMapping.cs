using AutoMapper;
using Domain.Models;
using Domain.Services.JobProvider.Profile.DTO;
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
        }
    }
}
