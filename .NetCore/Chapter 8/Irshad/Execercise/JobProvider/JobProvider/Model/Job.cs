using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace JobProvider.Model
{
    public class Job
    {
        public int Id { get; set; }

        [Required]
        public string? JobTitle { get; set; }
        [Required]
        public string? JobDescription { get; set; }
        [Required]
        public long Salary {  get; set; }
        [Required]
        public string? TypeOfWork { get; set; } 
        [Required]
        public string? JobExperience { get; set; }
        [Required]
        public string? Location { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
