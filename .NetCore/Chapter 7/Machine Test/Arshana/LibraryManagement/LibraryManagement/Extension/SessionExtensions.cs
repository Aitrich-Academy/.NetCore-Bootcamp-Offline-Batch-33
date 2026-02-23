using Microsoft.AspNetCore.Http;

namespace LibraryManagementSystem.Extensions
{
    public static class SessionExtensions
    {
        public static string GetUserRole(this ISession session)
            => session.GetString("UserRole") ?? string.Empty;

        public static bool IsAdmin(this ISession session)
            => session.GetUserRole() == "Admin";

        public static bool IsUser(this ISession session)
            => session.GetUserRole() == "User";
    }
}