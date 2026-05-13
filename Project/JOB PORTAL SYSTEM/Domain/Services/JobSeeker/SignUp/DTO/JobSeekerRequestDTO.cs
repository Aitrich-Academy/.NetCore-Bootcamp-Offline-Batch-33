using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.SignUp.DTO
{
    public class JobSeekerRequestDTO
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }
        public int Role { get; set; }
    }
}
