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
            var role = HttpContext.Session.GetString("UserRole");

            if (role == "Admin")
            {
                return RedirectToPage("/Account/Login");
            }
            return Page();
        }

        [BindProperty]
        public Books Books { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            var role = HttpContext.Session.GetString("UserRole");
            if(role == "Admin")
            {
                return RedirectToPage("/Account/Login");
            }
            if (!ModelState.IsValid)
            {
                return Page();
            }
            await bookService.CreateBookAsync(Books);
            return RedirectToPage("./Index");
        }
    }
}
