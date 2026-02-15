using JobPostManagement.Helpers;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace JobPostManagement.Models
{
    public class User 
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string Username { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        public Roles? Role { get; set; } // Admin || User

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;


        public List<JobApplication> JobApplications { get; set; } = new();
    }
}
