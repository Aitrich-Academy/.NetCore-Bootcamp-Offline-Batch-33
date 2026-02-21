using LibraryManagementSystem.Model;
using LibraryManagementSystem.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryManagementSystem.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly BookService _service;

        public IndexModel(BookService service)
        {
            _service = service;
        }

        public List<Book> Books { get; set; } = new();
        public string? UserRole { get; set; }
        public string? Username { get; set; }
        public int TotalBooks => Books.Count;

        public async Task<IActionResult> OnGetAsync()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("UserRole")))
            {
                return RedirectToPage("/Books/Login");
            }

            UserRole = HttpContext.Session.GetString("UserRole");
            Username = HttpContext.Session.GetString("Username");

            Books = await _service.GetAllBooksAsync();
            return Page();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            if (HttpContext.Session.GetString("UserRole") != "Admin")
                return RedirectToPage("/Login");

            await _service.DeleteBookAsync(id);
            return RedirectToPage();
        }
    }
}