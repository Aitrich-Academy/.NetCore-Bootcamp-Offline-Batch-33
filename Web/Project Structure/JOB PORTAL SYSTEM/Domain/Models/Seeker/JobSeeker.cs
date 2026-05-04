using Domain.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Seeker
{
    public class JobSeeker
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; } // Foreign key to SystemUser
        public SystemUser User { get; set; }

        public JobSeekerProfile Profile { get; set; }
        public ICollection<Resume> Resumes { get; set; }

    }
}
