using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Seeker
{
    public class Resume
    {
        public Guid Id { get; set; }
        public Guid JobSeekerId { get; set; } // Foreign key to JobSeeker
        public JobSeeker JobSeeker { get; set; } // Navigation property to JobSeeker

        public string FilePath { get; set; } // Path to the resume file
    }
}
