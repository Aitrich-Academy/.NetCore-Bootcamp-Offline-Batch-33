using LibraryManagementSystem.Model;
using LibraryManagementSystem.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryManagementSystem.Pages.Books
{
    public class EditModel : PageModel
    {
        private readonly BookService _service;

        public EditModel(BookService service)
        {
            _service = service;
        }

        [BindProperty]
        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (HttpContext.Session.GetString("UserRole") != "Admin")
                return RedirectToPage("/Login");

            Book = await _service.GetBookByIdAsync(id);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (HttpContext.Session.GetString("UserRole") != "Admin")
                return RedirectToPage("/Login");

            await _service.UpdateBookAsync(Book);
            return RedirectToPage("Index");
        }
    }
}