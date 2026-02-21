using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JobPostManagement.Data;
using JobPostManagement.Models;
using Microsoft.EntityFrameworkCore;
using JobPostManagement.Interfaces;


namespace JobPostManagement.Pages.Jobs
{
    public class AppliedJobsModel : PageModel
    {
        public readonly IJobApplicationService jobApplication;

        public AppliedJobsModel(IJobApplicationService jobApplication)
        {
            this.jobApplication = jobApplication;
        }

        public List<JobApplication> Applications { get; set; } = new();
        public async Task<IActionResult> OnGetAsync()
        {
            var userId = HttpContext.Session.GetString("UserId");

            if (userId == null)
            {
                return RedirectToPage("/Account/Login");
            }

            Applications = await jobApplication.GetUserApplicationsAsync(userId);

            return Page();
        }
    }
}
