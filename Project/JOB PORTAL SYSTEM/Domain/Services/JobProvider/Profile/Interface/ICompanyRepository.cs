using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.JobProvider.Profile.Interface
{
    public interface ICompanyRepository
    {
        Task<Company> AddAsync(Company company);
        Task<Company?> GetByIdAsync(Guid id);
        Task<IEnumerable<Company>> GetAllByUserIdAsync(Guid userId);
        Task<Company?> UpdateAsync(Guid CompanyId, Company company);
        Task<bool> DeleteAsync(Guid id);
    }
}
