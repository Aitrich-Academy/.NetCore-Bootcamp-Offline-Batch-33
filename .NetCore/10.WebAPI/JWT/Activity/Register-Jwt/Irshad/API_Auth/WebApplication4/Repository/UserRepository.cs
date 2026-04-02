using API_Auth.Data;
using API_Auth.Interface;
using API_Auth.Model;
using Microsoft.EntityFrameworkCore;

namespace API_Auth.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext context;
        public UserRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<User> RegisterAsync(User user)
        {
            await context.AddAsync(user);
            await context.SaveChangesAsync();

            return user;
        }

        public async Task<User> LoginAsync(string email, string password)
        {
            return await context.Users.FirstOrDefaultAsync(e => e.Email == email && e.Password == password);
        }

    }
}
