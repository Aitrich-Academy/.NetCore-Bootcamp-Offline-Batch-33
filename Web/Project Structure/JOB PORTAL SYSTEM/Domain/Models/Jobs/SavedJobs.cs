using Domain.Models.Seeker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Jobs
{
    public class SavedJobs
    {
        public Guid Id { get; set; }

        public Guid JobSeekerId { get; set; }
        public JobSeeker JobSeeker { get; set; }

        public Guid JobId { get; set; }
        public Job Job { get; set; }

        public DateTime SavedAt { get; set; }

    }
}
