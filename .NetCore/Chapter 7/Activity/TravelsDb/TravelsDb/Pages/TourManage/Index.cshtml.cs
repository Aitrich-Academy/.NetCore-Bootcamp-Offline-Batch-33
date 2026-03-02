using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TravelsDb.Interfaces;
using TravelsDb.Models;

namespace TravelsDb.Pages.Tours
{
    public class IndexModel : PageModel
    {
        private readonly ITourService service;
        public IndexModel(ITourService service)
        {
            this.service = service;
        }
        public List<Tour> Tours { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            var role = HttpContext.Session.GetString("UserRole");
            if(role == null)
            {
                return RedirectToPage("/Account/Login");
            }
            Tours = await service.GetAllAsync();
            return Page();
        }
    }
}
