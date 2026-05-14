using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<<< HEAD:Project/JOB PORTAL SYSTEM/Domain/Services/Auth/DTO/SignupRequestDTO.cs

========
>>>>>>>> 8966fbbee74d94746e827ec208f6f454f912d9aa:Project/JOB PORTAL SYSTEM/Domain/Services/Job_Provider/Signup/Dto/JobProviderSignupRequestDto.cs
namespace Domain.Services.Job_Provider.Signup.Dto
{
    public class SignupRequestDTO
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public Role Role { get; set; }
    }
}
