
using Registration_webApi.Dto;
using Registration_webApi.Interface;
using Registration_webApi.Model;

namespace Registration_webApi.Service
{
 
        public class UserService : IUserService
        {
            private readonly IUserRepository _userRepository;
            

            public UserService(IUserRepository userRepository)
            {
                _userRepository = userRepository;
                
            }

            public async Task<bool> RegisterUserAsync(RegistrationDto registerDto)
            {
                var existingUser = await _userRepository.GetUserByEmailAsync(registerDto.Email);
                if (existingUser != null)
                {
                    return false;
                }

                var user = new User
                {
                    Name = registerDto.Name,
                    Email = registerDto.Email,
                };

                await _userRepository.RegisterUserAsync(user);
                return true;
            }

        public async Task<LoginDto> LoginAsync(LoginDto loginDto)
        {
            var user = await _userRepository.GetUserByEmailAsync(loginDto.Email);

            if (user == null || user.Password != loginDto.Password)
            {
                return null;
            }

            return new LoginDto
            {
               
                Email = user.Email,
                Password = user.Password
            };
        }

    }
}

