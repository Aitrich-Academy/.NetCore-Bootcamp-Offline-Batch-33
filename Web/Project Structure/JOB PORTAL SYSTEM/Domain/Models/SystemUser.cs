using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class SystemUser
    {
        public Guid SystemUserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public Role Role { get; set; } 

        public ICollection<JobSeeker> JobSeekers { get; set; } = new List<JobSeeker>();
        public ICollection<Company> Companies { get; set; } = new List<Company>();
    }
}
