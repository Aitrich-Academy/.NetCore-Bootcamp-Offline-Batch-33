using Domain.Models;
using Domain.Services.Admin.Skills.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Admin.Skills.Interfaces
{
    public interface ISkillRepository
    {
        Task<Skill> AddSkillAsync(AddSkillDto addSkillDto);
        Task<Skill> GetSkillByIdAsync(Guid skillId);
    }
}
