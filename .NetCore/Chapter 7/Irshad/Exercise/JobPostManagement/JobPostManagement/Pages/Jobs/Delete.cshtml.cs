using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JobPostManagement.Data;

namespace JobPostManagement.Pages.Jobs
{
    public class DeleteModel : PageModel
    {
        public readonly AppDbContext context;

        public DeleteModel(AppDbContext context)
        {
            this.context = context;
        }

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

            context.Jobs.Remove(job);
            context.SaveChanges();
            return RedirectToPage("/Jobs/Index");
        }
    }
}
