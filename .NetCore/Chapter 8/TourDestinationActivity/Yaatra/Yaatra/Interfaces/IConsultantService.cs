using Yaatra.Dto;

namespace Yaatra.Interfaces
{
    public interface IConsultantService
    {
        Task<List<ConsultantDto>> GetAllAsync();
        Task<ConsultantDto> GetByIdAsync(int id);
        Task AddAsync(ConsultantDto consultant);
        Task UpdateAsync(ConsultantDto consultant);
        Task DeleteAsync(int id);
    }
}
