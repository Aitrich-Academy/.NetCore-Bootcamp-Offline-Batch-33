using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOB_PORTAL_SYSTEM.Api.JobSeeker.RequestObjects
{
    public class CreateCompanyProfileRequest
    {
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public Guid IndustryId { get; set; }
        public Guid LocationId { get; set; }



        // Temporary until JWT integration
        public Guid AuthId { get; set; }
    }
}
