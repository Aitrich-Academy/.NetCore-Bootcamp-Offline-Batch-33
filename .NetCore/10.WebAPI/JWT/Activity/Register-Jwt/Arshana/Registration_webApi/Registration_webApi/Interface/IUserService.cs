using Registration_webApi.Dto;
using Registration_webApi.Service;

namespace Registration_webApi.Interface
{
    public interface IUserService
    {
        Task<bool> RegisterUserAsync(RegistrationDto registerDto);
        Task<LoginDto> LoginAsync(LoginDto loginDto);
        

    }
}
