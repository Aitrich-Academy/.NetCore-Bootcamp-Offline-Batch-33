using API_Auth.DTO;

namespace API_Auth.Interface
{
    public interface IUserService
    {
        public Task<UserDto> RegisterAsync(UserDto dto);
        public Task<UserDto> LoginAsync(LoginDto dto);
    }
}
