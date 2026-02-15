using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPostManagement.Models
{
    public class JobApplication
    {
        [Key]
        public int Id { get; set; }

        
        //Foreign key
        [Required]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey("UserId")]
        public User User { get; set; }


        //Foreign key
        [Required]
        public int JobId { get; set; }

        [ForeignKey("JobId")]
        public Job Job { get; set; }

        public DateTime AppliedAt { get; set; } = DateTime.UtcNow;
    }
}
