using LibraryManagementSystem.DTOs;
using LibraryManagementSystem.Extensions;
using LibraryManagementSystem.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryManagementSystem.Pages.Admin
{
    public class CreateModel : PageModel
    {
        private readonly IBookService _service;

        public CreateModel(IBookService service)
        {
            _service = service;
        }

        [BindProperty]
        public BookCreateDto Book { get; set; } = new();

        public IActionResult OnGet()
        {
            if (!HttpContext.Session.IsAdmin())
                return RedirectToPage("/User/Login");

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!HttpContext.Session.IsAdmin())
                return RedirectToPage("/User/Login");

            if (!ModelState.IsValid)
                return Page();

            await _service.AddBookAsync(Book);
            return RedirectToPage("/Index");
        }
    }
}