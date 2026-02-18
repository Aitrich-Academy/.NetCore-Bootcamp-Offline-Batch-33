using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JobPostManagement.Data;
using JobPostManagement.Interfaces;

namespace JobPostManagement.Pages.Jobs
{
    public class DeleteModel : PageModel
    {
        public readonly IJobService jobService;

        public DeleteModel(IJobService jobService)
        {
            this.jobService = jobService;
        }

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

            await jobService.DeleteJobAsync(id);
            return RedirectToPage("/Jobs/Index");
        }
    }
}
