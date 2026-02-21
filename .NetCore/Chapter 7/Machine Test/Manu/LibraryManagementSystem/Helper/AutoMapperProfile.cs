using AutoMapper;
using LibraryManagementSystem.Dto;
using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<BookDto, Book>().ReverseMap();
        }
    }
}
