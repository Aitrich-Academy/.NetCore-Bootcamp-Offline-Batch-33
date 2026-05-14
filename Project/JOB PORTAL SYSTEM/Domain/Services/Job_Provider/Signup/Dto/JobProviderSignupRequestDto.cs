using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Job_Provider.Signup.Dto
{
    public class JobProviderSignupRequestDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        //public string Password { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Phone { get; set; }

        
    }
}
