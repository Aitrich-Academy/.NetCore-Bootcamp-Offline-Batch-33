using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class JobSeeker
    {
        public Guid Id { get; set; }

        [ForeignKey(nameof(AuthUser))]
<<<<<<< HEAD
        public Guid AuthUserId { get; set; } // Foreign key to AuthUser
        public AuthUser AuthUser { get; set; }
=======
        public Guid UserId { get; set; } // Foreign key to SystemUser
        [Required]
        public string Username { get; set; }

        public AuthUser User { get; set; }


        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }
        public int Role { get; set; }

        

>>>>>>> c3a084b795415919ea2d0ebc20713324eea677b3
        public JobSeekerProfile Profile { get; set; }

        public Resume Resume { get; set; }
        public ICollection<JobApplication> Applications { get; set; } = new List<JobApplication>();
       
        //public ICollection<JobSeekerSkills> Skills { get; set; } = new List<JobSeekerSkills>();
        public ICollection<SavedJob> SavedJobs { get; set; } = new List<SavedJob>();
    }   
}
