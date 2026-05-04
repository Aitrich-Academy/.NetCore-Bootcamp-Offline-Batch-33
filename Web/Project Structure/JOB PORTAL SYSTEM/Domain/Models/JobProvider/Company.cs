using Domain.Models.Auth;
using Domain.Models.Jobs;
using Domain.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.JobProvider
{
    public class Company
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public SystemUser User { get; set; }

        public string CompanyName { get; set; }

        public Guid IndustryId { get; set; }
        public Industry Industry { get; set; }

        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<CompanyMember> Members { get; set; }
        public ICollection<Job> Jobs { get; set; }


    }
}
