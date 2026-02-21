namespace LibraryManagementSystem.Helper
{
    public static class SessionAuthorization
    {
        public static bool IsAdmin(string? role)
        {
            return role == "Admin";
        }

        public static bool IsUser(string? role)
        {
            return role == "User";
        }
    }
}
