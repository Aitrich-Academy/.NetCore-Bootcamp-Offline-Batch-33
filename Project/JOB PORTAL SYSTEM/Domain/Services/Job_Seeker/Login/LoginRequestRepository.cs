using Domain.Data;
using Domain.Models;
using Domain.Services.Job_Seeker.Login.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Job_Seeker.Login
{
    public class LoginRequestRepository : ILoginRequestRepository
    {
        private readonly AppDbContext _context;

        public LoginRequestRepository(AppDbContext context)
        {
            _context = context;
        }
        public Models.AuthUser GetUserByEmail(string email)
        {
            var user = _context.AuthUsers
                .FirstOrDefault(e => e.Email == email);

            return user;
        }

        public Models.AuthUser GetUserByEmailPassword(string email, string password)
        {
            return _context.AuthUsers
                .FirstOrDefault(x =>
                    x.Email == email &&
                    x.Password == password);
        }
        public async Task<Models.AuthUser> GetUserByEmailAsync(string email)
        {
            return await _context.AuthUsers.FirstOrDefaultAsync(x => x.Email == email);
        }
        public async Task UpdateUserAsync(Models.AuthUser user)
        {
            _context.AuthUsers.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}
