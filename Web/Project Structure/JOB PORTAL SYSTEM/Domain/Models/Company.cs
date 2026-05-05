using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Company
    {
        public Guid Id { get; set; }

        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public SystemUser User { get; set; }

        [ForeignKey("Industry")]
        public Guid IndustryId { get; set; }
        public Industry Industry { get; set; }

        public string CompanyName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<CompanyMember> Members { get; set; } = new List<CompanyMember>();
        public ICollection<Job> Jobs { get; set; } = new List<Job>();


    }
}
