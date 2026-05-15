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
<<<<<<< HEAD
        Task<Company> AddCompanyAsync(CreateCompanyProfileRequest request, Guid providerId);
        Task<Company?> GetCompanyByIdAsync(Guid id);
        Task<IEnumerable<Company>> GetAllCompaniesByProviderIdAsync(Guid providerId);
        Task<Company?> UpdateCompanyAsync(Guid CompanyId, Company company);
=======
        Task<CompanyProfileDto> AddCompanyAsync(CreateCompanyProfileRequest request, Guid userId);
        Task<CompanyProfileDto?> GetCompanyByIdAsync(Guid id);
        Task<IEnumerable<CompanyProfileDto>> GetAllCompaniesByProviderIdAsync(Guid providerId);
        Task<CompanyProfileDto?> UpdateCompanyAsync(Guid CompanyId, Company company);

>>>>>>> c3a084b795415919ea2d0ebc20713324eea677b3
        Task<bool> DeleteCompanyAsync(Guid id);
    }
}
