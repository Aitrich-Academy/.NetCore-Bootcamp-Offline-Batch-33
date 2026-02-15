using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JobPostManagement.Data;
using JobPostManagement.Models;

namespace JobPostManagement.Pages.Jobs
{
    public class IndexModel : PageModel
    {
        public readonly AppDbContext context;

        public IndexModel(AppDbContext context)
        {
            this.context = context;
        }
        public List<Job> Jobs { get; set; } = new();
        public IActionResult OnGet()
        {
            if(HttpContext.Session.GetString("UserId") == null) 
            {
                return RedirectToPage("/Account/Login");
            }

            Jobs = context.Jobs.ToList();
            return Page();
        }
    }
}
