using System;
using System.Collections.Generic;
using System.Text;

namespace JobPortalApplication.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public Roles Role { get; set; } // e.g., "Admin", "Employer", "JobSeeker"
    }
}
