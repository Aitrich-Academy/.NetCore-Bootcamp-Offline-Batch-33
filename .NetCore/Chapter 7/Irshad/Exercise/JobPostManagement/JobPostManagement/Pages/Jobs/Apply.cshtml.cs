using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JobPostManagement.Data;
using JobPostManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace JobPostManagement.Pages.Jobs
{
    public class ApplyModel : PageModel
    {
        public readonly AppDbContext context;

        public ApplyModel(AppDbContext context)
        {
            this.context = context;
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

            var alreadyApplied = await context.JobApplications
                .AnyAsync(a => a.JobId == id && a.UserId == userId);

            if(alreadyApplied)
            {
                TempData["Message"] = "You have already for this job.";
                return RedirectToPage("/Jobs/Index");
            }

            var application = new JobApplication
            {
                UserId = userId,
                JobId = id,
                AppliedAt = DateTime.Now
            };

            context.JobApplications.Add(application);
            await context.SaveChangesAsync();

            TempData["Message"] = "Application submitted successfully!";
            return RedirectToPage("/Jobs/AppliedJobs");
        }
    }
}
