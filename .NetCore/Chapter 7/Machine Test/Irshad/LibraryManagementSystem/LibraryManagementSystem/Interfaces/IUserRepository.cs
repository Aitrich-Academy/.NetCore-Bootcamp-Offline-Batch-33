using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Interfaces
{
    public interface IUserRepository
    {
        public Task<Users?> LoginAsync(string email, string password);
        public Task<bool> EmailExistsAsync(string email);
        public Task RegisterAsync(Users user);
    }
}
