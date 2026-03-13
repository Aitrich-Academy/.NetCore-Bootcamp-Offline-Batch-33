using AutoMapper;
using TourManagement.Dto;
using TourManagement.Model;

namespace TourManagement.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DestinationDto, Destination>().ReverseMap();
            CreateMap<RegisterDto, User>();
        }
    }
}
