using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryManagementSystem.Pages
{
    public class LogoutModel : PageModel
    {
        public IActionResult OnGet()
        {
            // Clear session
            HttpContext.Session.Clear();

            // Redirect back to Login page
            return RedirectToPage("/Books/Login");
        }
    }
}