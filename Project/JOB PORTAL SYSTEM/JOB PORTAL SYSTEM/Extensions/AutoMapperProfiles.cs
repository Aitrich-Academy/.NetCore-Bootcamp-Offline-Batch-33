using AutoMapper;
using Domain.Models;
using Domain.Services.Auth.DTO;



namespace JOB_PORTAL_SYSTEM.Extensions
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            



            CreateMap<SignupRequestDTO, SignupRequest>().ReverseMap();

            CreateMap<AuthUser, LoginDTO>().ReverseMap();
        }




    }
}
