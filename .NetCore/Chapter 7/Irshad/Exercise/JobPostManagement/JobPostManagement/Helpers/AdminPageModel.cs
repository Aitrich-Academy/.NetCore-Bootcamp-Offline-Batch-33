using JobPostManagement.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobPostManagement.Helpers
{
    public class AdminPageModel : PageModel
    {
        public readonly AppDbContext context;
        public AdminPageModel(AppDbContext context)
        {
            this.context = context;
        }

        
    }
}
