using Registration_webApi.Model;

namespace Registration_webApi.Interface
{
    public interface IUserRepository
    {
        
        Task<User> RegisterUserAsync(User user);
        Task<User> GetUserByEmailAsync(string email);
       

    }
}
