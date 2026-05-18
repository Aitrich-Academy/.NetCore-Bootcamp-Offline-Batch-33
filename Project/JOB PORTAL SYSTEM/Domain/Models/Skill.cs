using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Skill
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        //public ICollection<JobSeekerSkills> JobSeekerSkills { get; set; } = new List<JobSeekerSkills>();

    }
}
