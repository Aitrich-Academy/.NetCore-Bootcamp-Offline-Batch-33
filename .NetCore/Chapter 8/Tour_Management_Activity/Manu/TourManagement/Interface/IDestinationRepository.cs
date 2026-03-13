using TourManagement.Dto;
using TourManagement.Model;

namespace TourManagement.Interface
{
    public interface IDestinationRepository
    {
        public Task<List<Destination>> GetAllDestinationAsync();
        public Task<Destination?> GetDestinationByIdAsync(int Id);
        public Task AddDestinationAsync(Destination Destination);
        public Task UpdateDestinationAsync(Destination destination);
        public Task DeleteDestinationAsync(Destination Destination);
    }
}
