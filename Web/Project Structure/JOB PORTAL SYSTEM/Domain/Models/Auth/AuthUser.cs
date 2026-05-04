using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Auth
{
    public class AuthUser
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public SystemUser SystemUser { get; set; } // Navigation property to SystemUser
    }
}
