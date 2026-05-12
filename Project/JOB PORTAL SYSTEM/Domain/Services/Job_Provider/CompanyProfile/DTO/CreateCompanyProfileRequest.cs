using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Job_Provider.CompanyProfile.DTO
{
    public class CreateCompanyProfileRequest
    {
        public Guid UserId { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public Guid IndustryId { get; set; }
        public Guid LocationId { get; set; }



    }
}
