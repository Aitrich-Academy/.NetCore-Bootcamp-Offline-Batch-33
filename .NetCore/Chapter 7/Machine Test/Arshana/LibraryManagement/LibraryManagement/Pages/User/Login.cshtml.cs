using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryManagementSystem.Pages.User
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string SelectedRole { get; set; } = "User";

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            HttpContext.Session.SetString("UserRole", SelectedRole);
            return RedirectToPage("/Index");
        }
    }
}