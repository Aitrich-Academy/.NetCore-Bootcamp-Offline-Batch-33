using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razorcrud.model;

namespace razorcrud.Pages.Studentz
{
    public class editModel : PageModel
    {

        private readonly StudentDbContext _context;

        public editModel(StudentDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            var existingStudent = await _context.Students.FirstOrDefaultAsync(s => s.NID == Student.NID);
            if (existingStudent == null)
                return NotFound();

            existingStudent.Name = Student.Name;
            existingStudent.Age = Student.Age;
            existingStudent.Course = Student.Course;

            await _context.SaveChangesAsync();

            return RedirectToPage("/Studentz/Index");
        }

    }
}


//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using razorcrud.model;

//namespace razorcrud.Pages.Studentz
//{
//    public class editModel : PageModel
//    {

//        private readonly StudentDbContext _context;

//        public editModel(StudentDbContext context)
//        {
//            _context = context;
//        }

//        [BindProperty]
//        public Student Student { get; set; }

//        public IActionResult OnGet(int id)
//        {
//            Student = _context.Students.FirstOrDefault(s => s.NID == id);
//            if (Student == null)
//            {
//                return NotFound();
//            }
//            return Page();
//        }

//        public IActionResult OnPost()
//        {
//            if (!ModelState.IsValid)
//                return Page();

//            var existingStudent = _context.Students.FirstOrDefault(s => s.NID == Student.NID);
//            if (existingStudent == null)
//                return NotFound();

//            existingStudent.Name = Student.Name;
//            existingStudent.Age = Student.Age;
//            existingStudent.Course = Student.Course;

//            _context.SaveChanges();

//            return RedirectToPage("/Studentz/Index");
//        }
//    }
//}


