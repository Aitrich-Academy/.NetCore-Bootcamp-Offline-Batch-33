using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryManagementSystem.Pages.Book
{
    public class CreateModel : PageModel
    {
        public readonly IBookService bookService;
        public CreateModel(IBookService bookService)
        {
            this.bookService = bookService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Books Books { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            await bookService.CreateBookAsync(Books);
            return RedirectToPage("./Index");
        }
    }
}
