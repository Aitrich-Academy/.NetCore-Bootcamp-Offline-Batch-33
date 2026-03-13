using Yaatra.Dto;
using Yaatra.Models;

namespace Yaatra.Interfaces
{
    public interface IConsultantRepository
    {
        Task<List<ConsultantDto>> GetAllAsync();

        Task<ConsultantDto> GetByIdAsync(int id);

        Task AddAsync(ConsultantDto consultant);

        Task UpdateAsync(ConsultantDto consultant);

        Task DeleteAsync(int id);
    }
}
