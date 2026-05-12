using Domain.Data;
using Domain.Models;
using Domain.Services.Admin.Skills.Dto;
using Domain.Services.Admin.Skills.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Admin.Skills
{
    public class SkillRepository : ISkillRepository
    {
        private readonly AppDbContext _context;
        public SkillRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Skill> AddSkillAsync(AddSkillDto addSkillDto)
        {
            try
            {
                var skill = new Skill
                {
                    Id = addSkillDto.Id,
                    Name = addSkillDto.Name
                };
                _context.Skills.AddAsync(skill);
                await _context.SaveChangesAsync();
                return skill;
            }
            catch(Exception ex)
            {
                throw new Exception($"Error adding skill: {ex.Message}");
            }
        }

        public async Task<Skill> GetSkillByIdAsync(Guid skillId)
        {
            return await _context.Skills.FindAsync(skillId);
        }
    }
}
