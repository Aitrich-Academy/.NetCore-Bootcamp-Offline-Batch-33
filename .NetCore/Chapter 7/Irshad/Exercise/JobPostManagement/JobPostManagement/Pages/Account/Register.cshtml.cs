using JobPostManagement.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JobPostManagement.Models;
using Microsoft.EntityFrameworkCore;
using JobPostManagement.Pages.Jobs;

namespace JobPostManagement.Pages.Account
{
    public class RegisterModel : PageModel
    {
        public readonly AppDbContext context;

        public RegisterModel(AppDbContext context)
        {
            this.context = context;
        }

        [BindProperty]
        public User User { get; set; } = new();

        public async Task<IActionResult> OnPostAsync()
        {
            User.Role = Helpers.Roles.User;
            if (!ModelState.IsValid)
            {
                return Page();
            }
            // Check if email already exists
            var existingUser = await context.Users.FirstOrDefaultAsync(u => u.Email == User.Email);
            if (existingUser != null)
            {
                ModelState.AddModelError(string.Empty, "Email is already registered.");
                return Page();
            }
            // Set default role to User
            context.Users.Add(User);
            await context.SaveChangesAsync();
            return RedirectToPage("Login");
        }
    }
}
