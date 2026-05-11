using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Services.Job_Provider.CompanyProfile.DTO;

namespace Domain.Services.Job_Provider.CompanyProfile.Interface
{
    public interface ICompanyService
    {
        Task<Company> AddCompanyAsync(CreateCompanyProfileRequest request);
        Task<Company?> GetCompanyByIdAsync(Guid id);
        Task<IEnumerable<Company>> GetAllCompaniesByUserIdAsync(Guid userId);
        Task<Company?> UpdateCompanyAsync(Guid CompanyId, Company company);
        Task<bool> DeleteCompanyAsync(Guid id);
    }
}
