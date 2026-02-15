using System;
using System.Collections.Generic;
using System.Text;

namespace JobPortalApplication.Models
{
    public class JobApplication
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public string ApplicantName { get; set; }
        public string Status { get; set; }
    }
}
