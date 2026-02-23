using LibraryManagementSystem.Extensions;
using LibraryManagementSystem.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryManagementSystem.Pages.Admin
{
    public class IndexModel : PageModel
    {
        private readonly IBookService _service;

        public IndexModel(IBookService service)
        {
            _service = service;
        }

        public int TotalBooks { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            if (!HttpContext.Session.IsAdmin())
                return RedirectToPage("/User/Login");

            TotalBooks = await _service.GetTotalBookCountAsync();
            return Page();
        }
    }
}