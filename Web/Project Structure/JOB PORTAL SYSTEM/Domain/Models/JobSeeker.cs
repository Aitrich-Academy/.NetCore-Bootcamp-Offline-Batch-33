using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class JobSeeker
    {
        public Guid Id { get; set; }

        [ForeignKey(nameof(AuthUser))]
        public Guid AuthUserId { get; set; } // Foreign key to AuthUser
        public AuthUser AuthUser { get; set; }

        public JobSeekerProfile Profile { get; set; }
        public Resume Resume { get; set; }
        public ICollection<JobApplication> Applications { get; set; } = new List<JobApplication>();
        public ICollection<Qualification> Qualifications { get; set; } = new List<Qualification>();
        public ICollection<JobSeekerSkills> Skills { get; set; } = new List<JobSeekerSkills>();
        public ICollection<SavedJobs> SavedJobs { get; set; } = new List<SavedJobs>();
    }   
}
