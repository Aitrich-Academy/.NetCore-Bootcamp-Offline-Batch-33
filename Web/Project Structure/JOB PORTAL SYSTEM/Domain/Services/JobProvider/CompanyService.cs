using Domain.Models;
using Domain.Services.JobProvider.Profile.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.JobProvider
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository companyRepository;
        public CompanyService(ICompanyRepository companyRepository)
        {
            this.companyRepository = companyRepository;
        }

        public async Task<Company> AddCompanyAsync(string name, string description, Guid industryId, Guid locationId, Guid userId)
        {
            try
            {
                var company = new Company
                {
                    Id = Guid.NewGuid(),
                    CompanyName = name,
                    Description = description,
                    IndustryId = industryId,
                    LocationId = locationId,
                    CreatedAt = DateTime.UtcNow
                };
                return await companyRepository.AddAsync(company);
            }
            catch(Exception ex) 
            {
                throw new Exception( ex.Message);
            }
        }

        public async Task<Company?> GetCompanyByIdAsync(Guid Id)
        {
            try
            {
                return await companyRepository.GetByIdAsync(Id);

            }
            catch (Exception ex)
            {
                throw new Exception( ex.Message);
            }
        }
        public async Task<IEnumerable<Company>> GetAllCompaniesByUserIdAsync(Guid userId)
        {
            try
            {

                return await companyRepository.GetAllByUserIdAsync(userId);
            }
            catch (Exception ex)
            {
                throw new Exception( ex.Message);
            }
        }
        public async Task<Company?> UpdateCompanyAsync(Guid CompanyId, Company company)
        {
            try
            {
                var existingCompany = await companyRepository.GetByIdAsync(CompanyId);
                if (existingCompany == null)
                {
                    throw new Exception("Company not found");
                }
                existingCompany.CompanyName = company.CompanyName;
                existingCompany.Description = company.Description;
                existingCompany.IndustryId = company.IndustryId;
                existingCompany.LocationId = company.LocationId;
                return await companyRepository.UpdateAsync(CompanyId, existingCompany);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<bool> DeleteCompanyAsync(Guid id)
        {
            try
            {
                var existingCompany = await companyRepository.GetByIdAsync(id);
                if (existingCompany == null)
                {
                    throw new Exception("Company not found");
                }
                return await companyRepository.DeleteAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
