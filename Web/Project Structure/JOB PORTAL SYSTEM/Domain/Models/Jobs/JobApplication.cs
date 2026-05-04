using Domain.Models.Enums;
using Domain.Models.Jobs;
using Domain.Models.Seeker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Jobs
{
    public class JobApplication
    {
        public Guid Id { get; set; }

        public Guid JobId { get; set; }
        public Job Job { get; set; }

        public Guid JobSeekerId { get; set; }
        public JobSeeker JobSeeker { get; set; }

        public Guid ResumeId { get; set; }
        public Resume Resume { get; set; }

        public DateTime AppliedDate { get; set; }
        public ApplicationStatus Status { get; set; }
        public Interview Interview { get; set; }
    }
}
