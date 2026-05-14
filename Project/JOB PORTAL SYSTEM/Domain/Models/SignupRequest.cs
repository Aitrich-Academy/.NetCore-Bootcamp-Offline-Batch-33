using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class SignupRequest
    {
        public Guid Id { get; set; }

<<<<<<< HEAD
=======
        public string UserName { get; set; }
>>>>>>> 3095fad8d7b73eedcdf894a5d944781877b9fd28

        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public JobStatus JobStatus { get; set; }


        [ForeignKey("Company")]
        public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }

    }
}
