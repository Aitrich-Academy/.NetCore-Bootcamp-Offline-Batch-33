using LibraryManagementSystem.Helpers;
using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryManagementSystem.Pages.Account
{
    public class RegisterModel : PageModel
    {
        public readonly IUserService userService;
        public RegisterModel(IUserService userService)
        {
            this.userService = userService;
        }


        
        [BindProperty]
        public Users user { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            user.Role = Roles.User;
            if (!ModelState.IsValid)
            {
                return Page();
            }
            // Check if email already exists
            if (await userService.EmailExistsAsync(user.Email))
            {
                ModelState.AddModelError(string.Empty, "Email is already registered.");
                return Page();
            }
            // Set default role to User
            await userService.RegisterAsync(user);
            return RedirectToPage("/Account/Login");
        }
    }
}
