using Domain.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Seeker
{
    public class JobSeekerSkills
    {
        public Guid Id { get; set; }

        public Guid JobSeekerId { get; set; }
        public JobSeeker JobSeeker { get; set; }

        public Guid SkillId { get; set; }
        public Skill Skill { get; set; }

    }
}
