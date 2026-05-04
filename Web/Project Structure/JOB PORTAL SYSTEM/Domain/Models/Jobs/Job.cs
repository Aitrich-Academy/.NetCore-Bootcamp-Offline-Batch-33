using Domain.Models.Enums;
using Domain.Models.JobProvider;
using Domain.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Jobs
{
    public class Job
    {
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }

        public Guid CategoryId { get; set; }
        public JobCategory Category { get; set; }

        public Guid LocationId { get; set; }
        public Location Location { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Salary { get; set; }

        public JobStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<JobApplication> Applications { get; set; }
    }
}
