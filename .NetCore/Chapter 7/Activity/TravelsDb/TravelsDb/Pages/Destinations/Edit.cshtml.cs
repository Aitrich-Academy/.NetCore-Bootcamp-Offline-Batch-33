using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TravelsDb.Interfaces;
using TravelsDb.Models;

namespace TravelsDb.Pages.Destinations
{
    public class EditModel : PageModel
    {
        private readonly IDestinationService service;
        private readonly IWebHostEnvironment webHostEnvironment;

        public EditModel(IDestinationService service, IWebHostEnvironment webHostEnvironment)
        {
            this.service = service;
            this.webHostEnvironment = webHostEnvironment;
        }

        [BindProperty]
        public Destination Destination { get; set; } = new();
        [BindProperty]
        public IFormFile? ImageFile { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            var role = HttpContext.Session.GetString("UserRole");
            if (role != "Admin")
            {
                return RedirectToPage("/Account/Login");
            }

            Destination = (await service.GetAllAsync()).FirstOrDefault(d => d.Id == id);
            if (Destination == null)
            {
                return NotFound();
            }
            return Page();
        }

        // Update destination
        public async Task<IActionResult> OnPostAsync()
        {
            var role = HttpContext.Session.GetString("UserRole");
            if (role != "Admin")
                return Forbid();

            if (!ModelState.IsValid)
                return Page();

            var existing = (await service.GetAllAsync())
                            .FirstOrDefault(d => d.Id == Destination.Id);

            if (existing == null)
                return NotFound();

            existing.Name = Destination.Name;
            existing.Description = Destination.Description;

            if (ImageFile != null)
            {
                string uploads = Path.Combine( webHostEnvironment.WebRootPath, "images");

                if (!Directory.Exists(uploads))
                    Directory.CreateDirectory(uploads);

                string fileName = Guid.NewGuid() + Path.GetExtension(ImageFile.FileName);
                string filePath = Path.Combine(uploads, fileName);

                using var stream = new FileStream(filePath, FileMode.Create);
                await ImageFile.CopyToAsync(stream);

                existing.ImagePath = "/images/" + fileName;
            }

            await service.UpdateAsync(existing);

            return RedirectToPage("Index");
        }

    }
}
