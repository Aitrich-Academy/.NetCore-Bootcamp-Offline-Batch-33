using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TravelsDb.Interfaces;
using TravelsDb.Models;

namespace TravelsDb.Pages.Destinations
{
    public class IndexModel : PageModel
    {
        private readonly IDestinationService _service;
        public IndexModel(IDestinationService service)
        {
            _service = service;
        }

        // List for displaying cards
        public List<Destination> Destinations { get; set; } = new();


        // Load destinations
        public async Task<IActionResult> OnGetAsync()
        {
            var username = HttpContext.Session.GetString("UserName");
            if (username == null)
            {
                return RedirectToPage("/Account/Login");
            }
            Destinations = await _service.GetAllAsync();
            return Page();
        }

    }
}