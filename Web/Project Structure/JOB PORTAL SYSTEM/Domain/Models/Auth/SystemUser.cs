using Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Auth
{
    public class SystemUser
    {
        public Guid Id { get; set; }
        public Guid AuthUserId { get; set; } // Foreign key to AuthUser
        public AuthUser AuthUser { get; set; } // Navigation property to AuthUser

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public Role Role { get; set; } 
    }
}
