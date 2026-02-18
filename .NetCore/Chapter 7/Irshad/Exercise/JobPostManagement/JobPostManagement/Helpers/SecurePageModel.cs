using JobPostManagement.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobPostManagement.Helpers
{
    public class SecurePageModel : PageModel
    {
        public readonly AppDbContext context;
        public SecurePageModel(AppDbContext context)
        {
            this.context = context;
        }

        public System.Security.Principal.IIdentity? GetIdentity()
        {
            return User.Identity;
        }

        public async Task<IActionResult> OnPostAsync(System.Security.Principal.IIdentity? identity)
        {
            if (!identity.IsAuthenticated)
            {
                return Redirect("/Account/Login");
            }
            if (!User.IsInRole("Admin"))
            {
                return RedirectToPage("/Account/AccessDenied");
            }
            // If authenticated and authorized, proceed as normal
            return Page();
        }
    }
}
