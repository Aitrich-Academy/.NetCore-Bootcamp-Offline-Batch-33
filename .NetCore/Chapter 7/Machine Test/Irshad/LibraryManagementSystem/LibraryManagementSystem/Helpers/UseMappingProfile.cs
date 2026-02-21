using AutoMapper;
using LibraryManagementSystem.Models;


namespace LibraryManagementSystem.Helpers
{
    public class UseMappingProfile : Profile
    {
        public UseMappingProfile()
        {
            CreateMap<Users, Users>().ReverseMap();

        }

    }
}
