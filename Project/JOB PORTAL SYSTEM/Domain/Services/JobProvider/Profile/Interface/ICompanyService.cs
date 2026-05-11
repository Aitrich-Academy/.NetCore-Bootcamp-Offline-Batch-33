using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.JobProvider.Profile.Interface
{
    public interface ICompanyService
    {
        Task<Company> AddCompanyAsync(string name, string description, Guid industryId, Guid locationId, Guid userId);
        Task<Company?> GetCompanyByIdAsync(Guid id);
        Task<IEnumerable<Company>> GetAllCompaniesByUserIdAsync(Guid userId);
        Task<Company?> UpdateCompanyAsync(Guid CompanyId, Company company);
        Task<bool> DeleteCompanyAsync(Guid id);
    }
}
