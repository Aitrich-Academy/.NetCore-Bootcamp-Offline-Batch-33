using JobPostManagement.Data;
using JobPostManagement.Interfaces.Repositories;
using JobPostManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace JobPostManagement.Repositories
{
    public class UserRepository : IUserRepository
    {
        public readonly AppDbContext context;

        public UserRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
            return await context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<User?> GetByEmailAndPasswordAsync(string email, string password)
        {
            return await context.Users.FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
        }

        public async Task<bool> EmailExistsAsync(string email)
        {
            return await context.Users.AnyAsync(u => u.Email == email);
        }

        public async Task AddAsync(User user)
        {
            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();
        }
    }
}
