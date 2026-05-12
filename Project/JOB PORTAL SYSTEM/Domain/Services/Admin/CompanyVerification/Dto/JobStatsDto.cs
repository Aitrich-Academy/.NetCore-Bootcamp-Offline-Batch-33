using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Admin.CompanyVerification.Dto
{
    public class JobStatsDto
    {
        public int TotalJobs { get; set; }
        public int DraftJobs { get; set; }
        public int PendingJobs { get; set; }
        public int ActiveJobs { get; set; }
        public int ClosedJobs { get; set; }
        public int ArchivedJobs { get; set; }
    }
}
