using Domain.Member.DTO;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Member.Interface
{
    public interface IApplicationservice
    {
        Task<JobApplication> UpdateStatusAsync(Guid id, UpdateApplicationStatus dto);

    }
}
