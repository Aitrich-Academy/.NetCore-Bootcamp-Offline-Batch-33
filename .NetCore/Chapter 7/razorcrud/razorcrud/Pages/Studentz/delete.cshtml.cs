using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razorcrud.model;

namespace razorcrud.Pages.Studentz
{
    public class deleteModel : PageModel
    {
        private readonly StudentDbContext _context;

        public deleteModel(StudentDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Student Student { get; set; }

        // GET: Show student to confirm deletion
        public async Task<IActionResult> OnGetAsync(int id)
        {
            Student = await _context.Students.FirstOrDefaultAsync(s => s.NID == id);

            if (Student == null)
            {
                return NotFound();
            }

            return Page();
        }

        // POST: Perform deletion
        public async Task<IActionResult> OnPostAsync()
        {
            if (Student == null || Student.NID == 0)
            {
                return NotFound();
            }

            var studentToDelete = await _context.Students.FindAsync(Student.NID);

            if (studentToDelete != null)
            {
                _context.Students.Remove(studentToDelete);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("/Studentz/index");
        }
    }
}
