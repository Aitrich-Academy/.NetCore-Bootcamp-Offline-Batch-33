using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razorcrud.model;

namespace razorcrud.Pages.Studentz
{
    public class viewModel : PageModel
    {
        private readonly StudentDbContext _context;

        public viewModel(StudentDbContext context)
        {
            _context = context;
        }

        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Student = await _context.Students.FirstOrDefaultAsync(s => s.NID == id);

            if (Student == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
