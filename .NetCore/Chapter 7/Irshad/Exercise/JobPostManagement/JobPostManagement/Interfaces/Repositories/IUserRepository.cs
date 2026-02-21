using JobPostManagement.Models;



namespace JobPostManagement.Interfaces.Repositories
{
    public interface IUserRepository
    {
        public Task<User?> GetByEmailAsync(string email);
        public Task<User?> GetByEmailAndPasswordAsync(string email, string password);
        public Task<bool> EmailExistsAsync(string email);
        public Task AddAsync(User user);
    }
}
