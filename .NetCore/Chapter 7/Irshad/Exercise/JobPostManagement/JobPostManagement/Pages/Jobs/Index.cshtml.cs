using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JobPostManagement.Data;
using JobPostManagement.Models;
using JobPostManagement.Interfaces;
using System.Threading.Tasks;

namespace JobPostManagement.Pages.Jobs
{
    public class IndexModel : PageModel
    {
        public readonly IJobService jobService;
        public IndexModel(IJobService jobService)
        {
            this.jobService = jobService;
        }
        public List<Job> Jobs { get; set; } = new();
        public async Task<IActionResult> OnGet()
        {
            if(HttpContext.Session.GetString("UserId") == null) 
            {
                return RedirectToPage("/Account/Login");
            }

            Jobs = await jobService.GetAllJobsAsync();
            return Page();
        }
    }
}
