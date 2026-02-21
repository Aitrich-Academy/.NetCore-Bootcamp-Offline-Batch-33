using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JobPostManagement.Data;
using JobPostManagement.Models;
using JobPostManagement.Interfaces;

namespace JobPostManagement.Pages.Jobs
{
    public class EditModel : PageModel
    {
        public readonly IJobService jobService;

        public EditModel(IJobService jobService)
        {
            this.jobService = jobService;
        }
        [BindProperty]
        public Job Job { get; set; } = new();
        public async Task<IActionResult> OnGetAsync(int id)
        {
            var role = HttpContext.Session.GetString("UserRole");
            if (role != "Admin")
            {
                return RedirectToPage("/Account/Login");
            }

            var job = await jobService.GetJobByIdAsync(id);

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

            await jobService.UpdateJobAsync(Job);
            return RedirectToPage("/Jobs/Index");
        }
    }
}
