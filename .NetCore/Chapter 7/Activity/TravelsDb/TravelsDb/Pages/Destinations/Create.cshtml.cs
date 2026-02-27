using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TravelsDb.Interfaces;
using TravelsDb.Models;
using TravelsDb.Services;

namespace TravelsDb.Pages.Destinations
{
    public class CreateModel : PageModel
    {
        private readonly IDestinationService service;
        private readonly IWebHostEnvironment webHostEnvironment;

        public CreateModel(IDestinationService service, IWebHostEnvironment webHostEnvironment)
        {
            this.service = service;
            this.webHostEnvironment = webHostEnvironment;
        }
        [BindProperty]
        public Destination Destination { get; set; }

        [BindProperty]
        public IFormFile? ImageFile { get; set; }

        public IActionResult OnGet()
        {
            var role = HttpContext.Session.GetString("UserRole");
            if (role != "Admin")
            {
                //return Forbid();
                return RedirectToPage("/Account/Login");
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var role = HttpContext.Session.GetString("UserRole");
            if (role != "Admin")
            {
                return RedirectToPage("/Account/Login");
            }

            if(!ModelState.IsValid)
            {
                return Page();
            }

            if(ImageFile != null)
            {
                string uploads = Path.Combine(webHostEnvironment.WebRootPath, "images");

                if(!Directory.Exists(uploads))
                {
                    Directory.CreateDirectory(uploads);
                }

                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(ImageFile.FileName);
                string filePath = Path.Combine(uploads, fileName);

                using var stream = new FileStream(filePath, FileMode.Create);
                await ImageFile.CopyToAsync(stream);

                Destination.ImagePath = $"/images/{fileName}";
            }

            await service.AddAsync(Destination);
            return RedirectToPage("./Index");
        }
    }
}
