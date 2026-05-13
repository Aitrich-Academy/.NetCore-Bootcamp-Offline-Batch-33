using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Job_Seeker.Login.DTO
{
    public class LoginrequestDto
    {
        public Guid Id { get; set; }
        public string? Username { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string PhoneNumber { get; set; }
        public Role Role { get; set; }
        public string? Token { get; set; }
    }
}
