using Domain.Models;
using Domain.Services.Job_Provider.CompanyProfile.DTO;
using Domain.Services.Job_Provider.CompanyProfile.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Job_Provider.CompanyProfile
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository companyRepository;
        public CompanyService(ICompanyRepository companyRepository)
        {
            this.companyRepository = companyRepository;
        }

        public async Task<Company> AddCompanyAsync(CreateCompanyProfileRequest request,Guid userId)
        {
            try
            {
                var jobProvider = await companyRepository
                    .GetByUserIdAsync(userId);

                if (jobProvider == null)
                {
                    throw new Exception("Job provider not found");
                }

                var company = new Company
                {
                    Id = Guid.NewGuid(),
                    CompanyName = request.CompanyName,
                    Description = request.Description,
                    IndustryId = request.IndustryId,
                    LocationId = request.LocationId,
                    Address = request.Address,
                    PhoneNumber = request.PhoneNumber,
                    Email = request.Email,
                    ProviderId = jobProvider.Id,
                    CreatedAt = DateTime.UtcNow,
                    IsVerified = false
                };

                return await companyRepository.AddAsync(company);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException?.Message ?? ex.Message);
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
        public async Task<IEnumerable<Company>> GetAllCompaniesByProviderIdAsync(Guid providerId)
        {
            try
            {

                return await companyRepository.GetAllByUserIdAsync(providerId);
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
                existingCompany .Address = company.Address;
                existingCompany .PhoneNumber = company.PhoneNumber;
                existingCompany .Description = company.Description;
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
