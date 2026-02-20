using JobPostManagement.Data;
using JobPostManagement.DTO;
using JobPostManagement.Interfaces;
using JobPostManagement.Interfaces.Repositories;
using JobPostManagement.Models;
using JobPostManagement.Repositories;
using JobPostManagement.Helpers;
using AutoMapper;

namespace JobPostManagement.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public async Task<User?> LoginAsync(string email, string password)
        {
            return await userRepository.GetByEmailAndPasswordAsync(email, password);
        }

        public async Task<bool> EmailExistsAsync(string email)
        {
            return await userRepository.EmailExistsAsync(email);
        }
        public async Task RegisterAsync(UserDto dto)
        {
            var user = mapper.Map<User>(dto);

            user.Id = Guid.NewGuid().ToString();
            user.Role = Roles.User;
            user.CreatedAt = DateTime.UtcNow;

            await userRepository.AddAsync(user);
        }
    }
}