using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JobPostManagement.Data;
using JobPostManagement.Models;
using Microsoft.EntityFrameworkCore;
using JobPostManagement.Interfaces;

namespace JobPostManagement.Pages.Jobs
{
    public class ApplyModel : PageModel
    {
        public readonly IJobApplicationService jobApplication;
        public ApplyModel(IJobApplicationService jobApplication)
        {
            this.jobApplication = jobApplication;
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var userId = HttpContext.Session.GetString("UserId");
            var role = HttpContext.Session.GetString("UserRole");

            if (userId == null)
            {
                return RedirectToPage("/Account/Login");
            }

            //admin cannot apply
            if(role == "Admin")
            {
                return RedirectToPage("/Jobs/Index");
            }

            if(await jobApplication.AlreadyAppliedAsync(id,userId))
            {
                TempData["Message"] = "You have already applied for this job.";
                return RedirectToPage("/Jobs/Index");
            }

            var application = new JobApplication
            {
                UserId = userId,
                JobId = id,
                AppliedAt = DateTime.Now
            };

            await jobApplication.ApplyToJobAsync(id, userId);

            TempData["Message"] = "Application submitted successfully!";
            return RedirectToPage("/Jobs/AppliedJobs");
        }
    }
}
