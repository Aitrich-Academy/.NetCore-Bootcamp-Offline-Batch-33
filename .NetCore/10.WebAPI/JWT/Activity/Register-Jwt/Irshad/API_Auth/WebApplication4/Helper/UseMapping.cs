using API_Auth.DTO;
using API_Auth.Model;
using AutoMapper;

namespace API_Auth.Helper
{
    public class UseMapping : Profile
    {
        public UseMapping()
        {
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<LoginDto, User>().ReverseMap();
        }
    }
}
