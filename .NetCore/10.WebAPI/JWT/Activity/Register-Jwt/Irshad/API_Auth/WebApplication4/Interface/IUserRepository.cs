using API_Auth.Model;

namespace API_Auth.Interface
{
    public interface IUserRepository
    {
        public Task<User> RegisterAsync(User user);
        public Task<User> LoginAsync(string email, string password);
    }
}
