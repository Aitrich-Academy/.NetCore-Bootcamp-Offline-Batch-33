using LibraryManagementSystem.DTOs;
using LibraryManagementSystem.Extensions;
using LibraryManagementSystem.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryManagementSystem.Pages.Admin
{
    public class DeleteModel : PageModel
    {
        private readonly IBookService _service;

        public DeleteModel(IBookService service)
        {
            _service = service;
        }

        public List<BookListDto> Books { get; set; } = new();

        public async Task<IActionResult> OnGetAsync()
        {
            if (!HttpContext.Session.IsAdmin())
                return RedirectToPage("/User/Login");

            Books = await _service.GetBooksAsync();
            return Page();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            if (!HttpContext.Session.IsAdmin())
                return RedirectToPage("/User/Login");

            await _service.DeleteBookAsync(id);
            return RedirectToPage("/Admin/Delete");
        }
    }
}