using Yaatra.Dto;
using Yaatra.Interfaces;

namespace Yaatra.Services
{
    public class ConsultantService
    {
        private readonly IConsultantRepository _repo;

        public ConsultantService(IConsultantRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<ConsultantDto>> GetAll()
        {
            return await _repo.GetAllAsync();
        }

        public async Task Add(ConsultantDto consultant)
        {
            await _repo.AddAsync(consultant);
        }

        public async Task Delete(int id)
        {
            await _repo.DeleteAsync(id);
        }

        public async Task<ConsultantDto> GetById(int id)
        {
            return await _repo.GetByIdAsync(id);
        }

        public async Task Update(ConsultantDto consultant)
        {
            await _repo.UpdateAsync(consultant);
        }
    }
}