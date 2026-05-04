using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Seeker
{
    public class JobSeekerProfile
    {
        public Guid Id { get; set; }
        public Guid JobSeekerId { get; set; } // Foreign key to JobSeeker
        public JobSeeker JobSeeker { get; set; } // Navigation property


        public string ProfileName { get; set; }
        public string ProfileDescription { get; set; }
    }
}
