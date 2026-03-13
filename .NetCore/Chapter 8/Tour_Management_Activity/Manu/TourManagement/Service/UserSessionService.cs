using TourManagement.Model;

namespace TourManagement.Service
{
    public class UserSessionService
    {
        public User? CurrentUser { get; set; }

        public bool IsLoggedIn => CurrentUser != null;

        public void SetUser(User user)
        {
            CurrentUser = user;
        }

        public void Logout()
        {
            CurrentUser = null;
        }
    }
}