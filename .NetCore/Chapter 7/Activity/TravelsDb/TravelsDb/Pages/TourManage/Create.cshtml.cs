using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TravelsDb.Interfaces;
using TravelsDb.Models;

namespace TravelsDb.Pages.Tours
{
    public class CreateModel : PageModel
    {
        private readonly ITourService service;
        private readonly IDestinationService destinationService;

        public CreateModel(ITourService service, IDestinationService destinationService)
        {
            this.service = service;
            this.destinationService = destinationService;
        }
        [BindProperty]
        public Tour Tour { get; set; } = new();
        public List<Destination> Destinations { get; set; } = new();
        public async Task<IActionResult> OnGetAsync()
        {
            var role = HttpContext.Session.GetString("UserRole");
            if (role != "Admin")
            {
                return RedirectToPage("/Account/Login");
            }
            Destinations = await destinationService.GetAllAsync();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var role = HttpContext.Session.GetString("UserRole");
            if (role != "Admin")
            {
                return RedirectToPage("/Account/Login");
            }
            if (!ModelState.IsValid)
            {
                Destinations = await destinationService.GetAllAsync();
                return Page();
            }
            await service.AddAsync(Tour);
            return RedirectToPage("./Index");
        }
    }
}
