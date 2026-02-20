using JobPostManagement.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JobPostManagement.Models;
using Microsoft.EntityFrameworkCore;
using JobPostManagement.Pages.Jobs;
using JobPostManagement.Interfaces;
using JobPostManagement.DTO;
using JobPostManagement.Helpers;

namespace JobPostManagement.Pages.Account
{
    public class RegisterModel : PageModel
    {
        public readonly IUserService usersService;
        public RegisterModel(IUserService usersService)
        {
            this.usersService = usersService;
        }

        [BindProperty]
        public User User { get; set; } = new();

        public async Task<IActionResult> OnPostAsync()
        {
            User.Role = Roles.User;
            if (!ModelState.IsValid)
            {
                return Page();
            }
            // Check if email already exists
            if (await usersService.EmailExistsAsync(User.Email))
            {
                ModelState.AddModelError(string.Empty, "Email is already registered.");
                return Page();
            }
            // Set default role to User
            await usersService.RegisterAsync(new UserDto
            {
                Email = User.Email,
                Password = User.Password,
                Role = Roles.User
            });
            return RedirectToPage("Login");
        }
    }
}
