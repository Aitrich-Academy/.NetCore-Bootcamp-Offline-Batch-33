using TourManagement.Dto;
using TourManagement.Model;

namespace TourManagement.Interface
{
    public interface IDestinationService
    {
        public Task<List<DestinationDto>> GetAllDestinationAsync();
        public Task<DestinationDto?> GetDestinationByIdAsync(int Id);
        public Task AddDestinationAsync(DestinationDto destinatinDto);
        public Task UpdateDestinationAsync(DestinationDto destinationDto);
        public Task DeleteDestinationAsync(int Id);
    }
}
