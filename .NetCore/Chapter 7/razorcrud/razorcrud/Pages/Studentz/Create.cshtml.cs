using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razorcrud.model;

namespace razorcrud.Pages.Studentz
{
    public class CreateModel : PageModel
    {
        private readonly StudentDbContext _context;

        public CreateModel(StudentDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Student student { get; set; }

        
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.Students.Add(student);
            _context.SaveChanges();

            return RedirectToPage("index");
        }
    }
       
    }

