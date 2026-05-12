using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Admin.CompanyVerification.Dto
{
    public class CompanyProfilesDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid IndustryId { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
