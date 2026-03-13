using AutoMapper;
using TourManagement.Dto;
using TourManagement.Interface;
using TourManagement.Model;
using TourManagement.Repository;

namespace TourManagement.Service
{
    public class DestinationService : IDestinationService
    {
        private readonly IDestinationRepository _destinationRepo;
        private readonly IMapper _mapper;

        public DestinationService(IDestinationRepository destinationRepository, IMapper mapper)
        {
            _destinationRepo = destinationRepository;
            _mapper = mapper;
        }

        public async Task<List<DestinationDto>> GetAllDestinationAsync()
        {
            var destinations = await _destinationRepo.GetAllDestinationAsync();
            return _mapper.Map<List<DestinationDto>>(destinations);
        }
        public async Task<DestinationDto?> GetDestinationByIdAsync(int id)
        {
            var destination = await _destinationRepo.GetDestinationByIdAsync(id);

            if (destination == null)
                return null;

            return _mapper.Map<DestinationDto>(destination);
        }
        public async Task AddDestinationAsync(DestinationDto destinationDto)
        {
            var destination = _mapper.Map<Destination>(destinationDto);
            await _destinationRepo.AddDestinationAsync(destination);
        }
        public async Task UpdateDestinationAsync(DestinationDto destinationDto)
        {
            var destination = _mapper.Map<Destination>(destinationDto);
            await _destinationRepo.UpdateDestinationAsync(destination);
        }
        public async Task DeleteDestinationAsync(int id)
        {
            var destination = await _destinationRepo.GetDestinationByIdAsync(id);
            if(destination != null)
            {
                await _destinationRepo.DeleteDestinationAsync(destination);
            }
        }
    }
}
