using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TravelsDb.Interfaces;
using TravelsDb.Models;

namespace TravelsDb.Pages.Tours
{
    public class DeleteModel : PageModel
    {
        private readonly ITourService service;
        public DeleteModel(ITourService service)
        {
            this.service = service;
        }
        public Tour Tour { get; set; }
        
        public async Task<IActionResult> OnGetAsync(int id)
        {
            var role = HttpContext.Session.GetString("UserRole");
            if (role != "Admin")
            {
                return RedirectToPage("/Account/Login");
            }
            var tour = await service.GetAllByIdAsync(id);
            if (tour == null)
            {
                return NotFound();
            }
            Tour = tour;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            var role = HttpContext.Session.GetString("UserRole");
            if (role != "Admin")
            {
                return RedirectToPage("/Account/Login");
            }
            await service.DeleteAsync(id);
            return RedirectToPage("./Index");
        }
    }
}
