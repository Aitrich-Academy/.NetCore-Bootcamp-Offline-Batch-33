using TourManagement.Model;

namespace TourManagement.Interface
{
    public interface IUserRepository
    {
        Task<User?> GetByEmailAsync(string email);
        Task AddUserAsync(User user);
    }
}
