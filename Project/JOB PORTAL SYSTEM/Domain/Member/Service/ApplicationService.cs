using Domain.Member.DTO;
using Domain.Member.Interface;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Member.Service
{
    public class ApplicationService : IApplicationservice
    {
        private readonly IApplicationRepository _repository;

        public ApplicationService(IApplicationRepository repository)
        {
            _repository = repository;
        }

        public async Task<JobApplication> UpdateStatusAsync(Guid id, UpdateApplicationStatus dto)
        {
            var application = await _repository.GetByIdAsync(id);

            if (application == null)
                return null;

            application.Status = dto.Status;

            await _repository.UpdateAsync(application);

            return application;
        }
    }
}