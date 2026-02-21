using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryManagementSystem.Pages.Books
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string ErrorMessage { get; set; }

        public IActionResult OnPost()
        {
            if (Username == "admin" && Password == "admin123")
            {
                HttpContext.Session.SetString("UserRole", "Admin");
                HttpContext.Session.SetString("Username", "Admin");
                return RedirectToPage("/Books/Index");
            }
            else if (Username == "user" && Password == "user123")
            {
                HttpContext.Session.SetString("UserRole", "User");
                HttpContext.Session.SetString("Username", "User");
                return RedirectToPage("/Books/Index");
            }

            ErrorMessage = "Invalid username or password";
            return Page();
        }
    }
}