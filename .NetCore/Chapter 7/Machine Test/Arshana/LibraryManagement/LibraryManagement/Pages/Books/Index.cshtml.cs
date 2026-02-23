using LibraryManagementSystem.DTOs;
using LibraryManagementSystem.Extensions;
using LibraryManagementSystem.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryManagementSystem.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly IBookService _service;

        public IndexModel(IBookService service)
        {
            _service = service;
        }

        public List<BookListDto> Books { get; set; } = new();
        public string UserRole { get; set; } = "";

        public async Task OnGetAsync()
        {
            UserRole = HttpContext.Session.GetUserRole();
            Books = await _service.GetBooksAsync();
        }
    }
}