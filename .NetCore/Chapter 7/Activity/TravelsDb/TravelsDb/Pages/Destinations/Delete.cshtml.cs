using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TravelsDb.Interfaces;
using TravelsDb.Models;

namespace TravelsDb.Pages.Destinations
{
    public class DeleteModel : PageModel
    {
        private readonly IDestinationService service;

        public DeleteModel(IDestinationService service)
        {
            this.service = service;
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            await service.DeleteAsync(id);
            return RedirectToPage("./Index");
        }
    }
}
