using JobPostManagement.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JobPostManagement.Models;
using Microsoft.EntityFrameworkCore;
using JobPostManagement.Interfaces;

namespace JobPostManagement.Pages.Jobs
{
    public class CreateModel : PageModel
    {
        public readonly IJobService jobService;

        public CreateModel(IJobService jobService)
        {
            this.jobService = jobService;
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
            await jobService.CreateJobAsync(Job);
            return RedirectToPage("/Jobs/Index");
        }
    }
}
