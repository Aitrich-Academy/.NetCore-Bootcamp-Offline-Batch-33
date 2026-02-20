


using AutoMapper;
using JobPostManagement.DTO;
using JobPostManagement.Models;

namespace JobPostManagement.Helpers
{
    public class UseMappingProfile : Profile
    {
        public UseMappingProfile()
        {
            CreateMap<UserDto, User>();
        }
    }
}
