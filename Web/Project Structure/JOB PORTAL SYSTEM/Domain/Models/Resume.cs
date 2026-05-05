using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Resume
    {
        public Guid Id { get; set; }
        [ForeignKey("JobSeeker")]
        public Guid JobSeekerId { get; set; } // Foreign key to JobSeeker
        public JobSeeker JobSeeker { get; set; } // Navigation property to JobSeeker

        public string FilePath { get; set; } // Path to the resume file

        public ICollection<JobApplication> JobApplications { get; set; } = new List<JobApplication>(); // Navigation property to JobApplications
    }
}
