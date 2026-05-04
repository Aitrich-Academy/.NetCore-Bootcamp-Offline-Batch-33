using Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.JobProvider
{
    public class CompanyMember
    {
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; } // Foreign key to Company
        public string Name { get; set; }
        public string Email { get; set; }
        public CompanyRole Role { get; set; } // Enum for Company roles (e.g., HR, Recruiter, Manager)
    }
}
