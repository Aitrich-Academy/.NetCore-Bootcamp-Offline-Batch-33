using Domain.Services.Admin.Location.Dto;

namespace Domain.Services.Admin.Location.Interface
{
    public interface ILocationRepository
    {
        Task<string> AddLocationAsync(AddLocationDto dto);

    }
}
