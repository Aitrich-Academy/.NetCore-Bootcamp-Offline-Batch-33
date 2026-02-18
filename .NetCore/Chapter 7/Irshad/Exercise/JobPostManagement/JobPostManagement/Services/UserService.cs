using JobPostManagement.Data;
using JobPostManagement.Interfaces;
using JobPostManagement.Interfaces.Repositories;
using JobPostManagement.Models;
using JobPostManagement.Repositories;

namespace JobPostManagement.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<User?> LoginAsync(string email, string password)
        {
            return await userRepository.GetByEmailAndPasswordAsync(email, password);
        }

        public async Task<bool> EmailExistsAsync(string email)
        {
            return await userRepository.EmailExistsAsync(email);
        }
        public async Task RegisterAsync(User user)
        {
            await userRepository.AddAsync(user);
        }
        
    }
}
