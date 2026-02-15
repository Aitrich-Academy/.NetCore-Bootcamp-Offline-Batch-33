using System.ComponentModel.DataAnnotations;

namespace JobPostManagement.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Company { get; set; } = string.Empty;

        [Required]
        public string Location { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;


        public List<JobApplication> JobApplications { get; set; } = new();
    }
}
