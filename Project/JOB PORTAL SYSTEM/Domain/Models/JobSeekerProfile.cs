using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class JobSeekerProfile
    {
        public Guid Id { get; set; }
        [ForeignKey("JobSeeker")]
        public Guid JobSeekerId { get; set; } // Foreign key to JobSeeker
        public JobSeeker JobSeeker { get; set; } // Navigation property
        public string ProfileName { get; set; }

        public string ProfileDescription { get; set; }

        public  string Experience {  get; set; }

        public  string Skills { get; set; }

        public string Qualifications { get; set; }
    }
}
