using LibraryManagementSystem.Pages;
using LibraryManagementSystem.Pages.Books;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryManagementSystem.Pages
{
    public class IndexModel : PageModel
    {
        public string? UserRole { get; set; }

        public async Task OnGetAsync()
        {
            UserRole = HttpContext.Session.GetString("UserRole");
        }
    }
}
