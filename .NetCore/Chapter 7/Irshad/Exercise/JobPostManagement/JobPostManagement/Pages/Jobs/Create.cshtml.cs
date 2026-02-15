using JobPostManagement.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JobPostManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace JobPostManagement.Pages.Jobs
{
    public class CreateModel : PageModel
    {
        public readonly AppDbContext context;

        public CreateModel(AppDbContext context)
        {
            this.context = context;
        }
        [BindProperty]
        public Job Job { get; set; } = new();

        public IActionResult OnGet()
        {
            var role = HttpContext.Session.GetString("UserRole");
            if (role != "Admin")
            {
                return RedirectToPage("/Account/Login");
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var role = HttpContext.Session.GetString("UserRole");
            if (role != "Admin")
            {
                return RedirectToPage("/Account/Login");
            }
            if (!ModelState.IsValid)
            {
                return Page();
            }
            context.Jobs.Add(Job);
            await context.SaveChangesAsync();
            return RedirectToPage("/Jobs/Index");
        }
    }
}
