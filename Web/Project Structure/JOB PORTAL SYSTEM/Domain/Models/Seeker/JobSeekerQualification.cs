using Domain.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Seeker
{
    public class JobSeekerQualification
    {
        public Guid Id { get; set; }
        public Guid JobSeekerId { get; set; } // Foreign key to JobSeeker
        public JobSeeker JobSeeker { get; set; } // Navigation property to JobSeeker


        public Guid QualificationId { get; set; } // Foreign key to Qualification
        public Qualification Qualification { get; set; } // Navigation property to Qualification

        public string University { get; set; }
        public DateTime StartYear { get; set; }
        public DateTime EndYear { get; set; }
    }
}
