using Domain.Data;
using Domain.Enums;
using Domain.Models;
using Domain.Services.Admin.Interface;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services.Admin.Repository
{
    public class AdminRepositories : IAdminRepositories
    {
        private readonly AppDbContext _context;

        public AdminRepositories(AppDbContext context)
        {
            _context = context;
        }

        public async Task<AuthUser> LoginAsync(string email,string password)
        {
            try
            {
                return await _context.AuthUsers.FirstOrDefaultAsync
                    (x =>x.Email == email &&
                        x.Password == password &&
                        x.Role == Role.Admin);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error while login : {ex.Message}");
            }
        }
    }
}