using Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Jobs
{
    public class Interview
    {
        public Guid Id { get; set; }

        public Guid ApplicationId { get; set; }
        public JobApplication Application { get; set; }

        public DateTime InterviewDate { get; set; }
        public InterviewMode Mode { get; set; }
        public InterviewStatus Status { get; set; }
    }
}
