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
            if (id == null || bookService.GetAllBooksAsync() == null)
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
            }
            return Page();
        }
    }
}
