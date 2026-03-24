using Microsoft.EntityFrameworkCore;
using Yaatra.Data;
using Yaatra.Dto;
using Yaatra.Interfaces;
using Yaatra.Models;

namespace Yaatra.Repositories
{
    public class ConsultantRepository : IConsultantRepository
    {
        private readonly AppDbContext _context;

        public ConsultantRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<ConsultantDto>> GetAllAsync()
        {
            return await _context.Consultants
                .Select(x => new ConsultantDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Email = x.Email,
                    Phone = x.Phone,
                    Username = x.Username,
                    JoiningDate = x.JoiningDate,

                }).ToListAsync();
        }

        public async Task<ConsultantDto> GetByIdAsync(int id)
        {
            var c = await _context.Consultants.FindAsync(id);

            return new ConsultantDto
            {
                Id = c.Id,
                Name = c.Name,
                Email = c.Email,
                Phone = c.Phone,
                Username = c.Username,
                JoiningDate = c.JoiningDate,
                
            };
        }
        public async Task AddAsync(ConsultantDto consultant)
        {
            var data = new Consultant
            {
                Name = consultant.Name,
                Email = consultant.Email,
                Phone = consultant.Phone,
                Username = consultant.Username,
                
                JoiningDate = DateTime.Now
            };

            _context.Consultants.Add(data);

            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(ConsultantDto consultant)
        {
            var data = await _context.Consultants.FindAsync(consultant.Id);

            data.Name = consultant.Name;
            data.Email = consultant.Email;
            data.Phone = consultant.Phone;
            data.Username = consultant.Username;
            data.JoiningDate = consultant.JoiningDate;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var data = await _context.Consultants.FindAsync(id);

            _context.Consultants.Remove(data);

            await _context.SaveChangesAsync();
        }
    }
}
