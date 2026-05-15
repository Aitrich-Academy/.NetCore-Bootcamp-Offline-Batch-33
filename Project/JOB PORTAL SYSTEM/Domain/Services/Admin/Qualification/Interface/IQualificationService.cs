using Domain.Services.Admin.Qualification.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Admin.Qualification.Interface
{
    public interface IQualificationService
    {
        Task<string> AddQualificationAsync( AddQualificationDto dto);
    }
}
