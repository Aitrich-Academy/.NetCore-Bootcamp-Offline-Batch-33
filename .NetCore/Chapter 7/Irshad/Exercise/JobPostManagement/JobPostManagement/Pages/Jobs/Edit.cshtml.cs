using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JobPostManagement.Data;
using JobPostManagement.Models;

namespace JobPostManagement.Pages.Jobs
{
    public class EditModel : PageModel
    {
        public readonly AppDbContext context;

        public EditModel(AppDbContext context)
        {
            this.context = context;
        }
        [BindProperty]
        public Job Job { get; set; } = new();
        public IActionResult OnGet(int id)
        {
            var role = HttpContext.Session.GetString("UserRole");
            if (role != "Admin")
            {
                return RedirectToPage("/Account/Login");
            }

            var job = context.Jobs.Find(id);

            if (job == null)
            {
                return NotFound();
            }
            Job = job;
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

            context.Jobs.Update(Job);
            await context.SaveChangesAsync();
            return RedirectToPage("/Jobs/Index");
        }
    }
}
