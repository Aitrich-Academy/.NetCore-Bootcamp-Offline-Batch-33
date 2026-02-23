using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryManagement.Pages.User
{
    public class LogoutModel : PageModel
    {
        public IActionResult OnGet()
        {
            // ✅ Clear session for both Admin and User
            HttpContext.Session.Clear();

            // Redirect to Login page
            return RedirectToPage("/User/Login");
        }
    }
}