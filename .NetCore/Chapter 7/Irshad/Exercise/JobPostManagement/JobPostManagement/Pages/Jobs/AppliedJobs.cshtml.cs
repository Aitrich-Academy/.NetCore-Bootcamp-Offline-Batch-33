using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JobPostManagement.Data;
using JobPostManagement.Models;
using Microsoft.EntityFrameworkCore;


namespace JobPostManagement.Pages.Jobs
{
    public class AppliedJobsModel : PageModel
    {
        public readonly AppDbContext context;

        public AppliedJobsModel(AppDbContext context)
        {
            this.context = context;
        }

        public List<JobApplication> Applications { get; set; } = new();
        public IActionResult OnGet()
        {
            var userId = HttpContext.Session.GetString("UserId");

            if (userId == null)
            {
                return RedirectToPage("/Account/Login");
            }

            Applications = context.JobApplications
                .Include(a => a.Job)
                .Where(a => a.UserId == userId)
                .ToList();

            return Page();
        }
    }
}
