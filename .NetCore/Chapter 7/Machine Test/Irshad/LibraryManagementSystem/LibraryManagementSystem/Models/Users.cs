using LibraryManagementSystem.Helpers;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }

        public Roles Role { get; set; }
    }
}
