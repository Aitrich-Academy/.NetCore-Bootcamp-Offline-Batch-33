using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Services
{
    public class UserService : IUserService
    {
        public readonly IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public Task<Users?> LoginAsync(string email, string password)
        {
            return userRepository.LoginAsync(email, password);
        }

        public Task<bool> EmailExistsAsync(string email)
        {
            return userRepository.EmailExistsAsync(email);
        }

        public Task RegisterAsync(Users user)
        {
            return userRepository.RegisterAsync(user);
        }
    }
}
