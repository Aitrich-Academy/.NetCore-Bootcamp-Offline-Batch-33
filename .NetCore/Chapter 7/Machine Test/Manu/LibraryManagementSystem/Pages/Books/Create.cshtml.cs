using LibraryManagementSystem.Helper;
using LibraryManagementSystem.Model;
using LibraryManagementSystem.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryManagementSystem.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly BookService _service;

        public CreateModel(BookService service)
        {
            _service = service;
        }

        [BindProperty]
        public Book Book { get; set; } = new();

        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("UserRole") != "Admin")
                return RedirectToPage("/Login");

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var role = HttpContext.Session.GetString("UserRole");

            if (!SessionAuthorization.IsAdmin(role))
            {
                return RedirectToPage("/Books/Index");
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _service.AddBookAsync(Book);
            return RedirectToPage("Index");
        }
    }
}