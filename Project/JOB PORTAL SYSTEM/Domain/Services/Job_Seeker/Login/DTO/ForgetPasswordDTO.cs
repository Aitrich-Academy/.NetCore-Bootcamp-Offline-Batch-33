using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Job_Seeker.Login.DTO
{
    public class ForgetPasswordDTO
    {
        public string Email {  get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
