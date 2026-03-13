using System.ComponentModel.DataAnnotations;
using TourManagement.Model;

namespace TourManagement.Dto
{
    public class RegisterDto
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [Required]
        public Gender Gender { get; set; }
    }
}
