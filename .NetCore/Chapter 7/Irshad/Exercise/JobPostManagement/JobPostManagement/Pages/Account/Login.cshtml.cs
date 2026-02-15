using Microsoft.AspNetCore.Mvc;
using JobPostManagement.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JobPostManagement.Models;
using Microsoft.EntityFrameworkCore;
using JobPostManagement.Pages.Jobs;

namespace JobPostManagement.Pages.Account
{
    public class LoginModel : PageModel
    {
        public readonly AppDbContext context;

        public LoginModel(AppDbContext context)
        {
            this.context = context;
        }
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Password { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var user = context.Users.FirstOrDefault(u => u.Email == Email && u.Password == Password);
            if (user == null)
            {
                ModelState.AddModelError("", "Invalid email or password.");
                return Page();
            }
            // Store user info in session
            HttpContext.Session.SetString("UserId", user.Id);
            HttpContext.Session.SetString("UserRole", user.Role.ToString());
            HttpContext.Session.SetString("Username", user.Username);
            return RedirectToPage("/Jobs/Index");
        }
    }
}