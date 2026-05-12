using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class SignupRequest
    {
        public Guid Id { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public JobStatus JobStatus { get; set; }

        
    }
}
