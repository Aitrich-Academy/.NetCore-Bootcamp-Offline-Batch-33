using JobPostManagement.DTO;
using JobPostManagement.Models;

namespace JobPostManagement.Interfaces
{
    public interface IUserService
    {
        public Task<User?> LoginAsync(string email, string password);
        public Task<bool> EmailExistsAsync(string email);
        public Task RegisterAsync(UserDto dto);

    }
}
