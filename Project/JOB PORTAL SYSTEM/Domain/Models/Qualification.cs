using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Qualification
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
<<<<<<< HEAD
        public ICollection<JobSeekerQualification> JobSeekerQualifications { get; set; } = new List<JobSeekerQualification>();
=======

        
>>>>>>> c3a084b795415919ea2d0ebc20713324eea677b3

    }
}
