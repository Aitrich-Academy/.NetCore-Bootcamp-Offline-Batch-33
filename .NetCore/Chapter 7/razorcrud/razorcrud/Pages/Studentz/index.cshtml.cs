using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razorcrud.model;

namespace razorcrud.Pages.Studentz
{
    public class indexModel : PageModel
    {private readonly StudentDbContext _context;
        public indexModel(StudentDbContext context) 
        {  _context = context; }
        public IList<Student> StudentList { get; set; }

        public async Task OnGetAsync()
        {
            StudentList = await _context.Students.ToListAsync();

        }
    }
}
