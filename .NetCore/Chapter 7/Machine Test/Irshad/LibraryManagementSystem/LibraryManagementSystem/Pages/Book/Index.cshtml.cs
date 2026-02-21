using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryManagementSystem.Pages.Book
{
    public class IndexModel : PageModel
    {
        public readonly IBookService bookService;

        public IndexModel(IBookService bookService)
        {
            this.bookService = bookService;
        }

        public IList<Books> Books { get; set; } = default!;
        public async Task OnGetAsync()
        {
            Books = await bookService.GetAllBooksAsync();
        }

        
    }
}
