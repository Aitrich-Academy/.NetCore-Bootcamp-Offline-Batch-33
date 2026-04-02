using AutoMapper;
using Registration_webApi.Dto;
using Registration_webApi.Model;

namespace Registration_webApi.Extension
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RegistrationDto, User>();
            CreateMap<LoginDto, User>();
        }
    }
}
