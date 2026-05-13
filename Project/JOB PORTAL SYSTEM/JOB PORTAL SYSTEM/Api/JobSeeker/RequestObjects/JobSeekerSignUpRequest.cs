using System.ComponentModel.DataAnnotations;

namespace JOB_PORTAL_SYSTEM.API.JobSeeker.RequestObjects
{
    public class JobSeekerSignUpRequest
    {
        public string? Username { get; set; }
        [Required]

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
