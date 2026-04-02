using API_Auth.DTO;
using API_Auth.Interface;
using API_Auth.Model;
using AutoMapper;

namespace API_Auth.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository repository;
        private readonly IMapper mapper;

        public UserService(IUserRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<UserDto> RegisterAsync(UserDto dto)
        {
            var userEntity = mapper.Map<User>(dto);
            var savedUser = await repository.RegisterAsync(userEntity);
            return mapper.Map<UserDto>(savedUser);
        }

        public async Task<UserDto> LoginAsync(LoginDto dto)
        {
            if (dto == null || string.IsNullOrEmpty(dto.Email) || string.IsNullOrEmpty(dto.Password))
                return null;

            var savedUser = await repository.LoginAsync(dto.Email, dto.Password);
            if (savedUser == null)
                return null;

            return mapper.Map<UserDto>(savedUser);
        }
    }
}
