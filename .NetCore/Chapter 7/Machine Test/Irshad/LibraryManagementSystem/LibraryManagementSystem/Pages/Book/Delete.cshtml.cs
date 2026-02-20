using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryManagementSystem.Pages.Book
{
    public class DeleteModel : PageModel
    {
        public readonly IBookService bookService;
        public DeleteModel(IBookService bookService)
        {
            this.bookService = bookService;
        }
        [BindProperty]
        public Books Books { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            var role = HttpContext.Session.GetString("UserRole");
            if (role != "Admin")
            {
                return RedirectToPage("/Account/Login");
            }
            if (id == null)
            {
                return RedirectToPage("./Index");
            }

            var books = await bookService.GetBookByIdAsync(id.Value);

            if (books == null)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                Books = books;
                return Page();
            }
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            var role = HttpContext.Session.GetString("UserRole");
            if (role != "Admin")
            {
                return RedirectToPage("/Account/Login");
            }
            if (id == null)
            {
                return RedirectToPage("./Index");
            }
            var books = await bookService.GetBookByIdAsync(id.Value);

            if (books == null)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                Books = books;
                await bookService.DeleteBookAsync(Books.Id);
                return RedirectToPage("./Index");
            }
        }
    }
}
