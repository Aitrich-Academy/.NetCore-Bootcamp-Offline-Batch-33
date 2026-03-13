using TourManagement.Dto;
using TourManagement.Model;

namespace TourManagement.Interface
{
    public interface IAuthService
    {
        Task<bool> RegisterAsync(RegisterDto dto);
        Task<User?> LoginAsync(LoginDto dto);
    }
}
