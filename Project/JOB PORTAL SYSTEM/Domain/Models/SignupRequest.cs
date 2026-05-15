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
>>>>>>> c3a084b795415919ea2d0ebc20713324eea677b3
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
<<<<<<< HEAD
        public JobStatus JobStatus { get; set; }

=======
        [Required]
   

        public JobStatus JobStatus { get; set; }


        [ForeignKey("Company")]
        public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
        public Role Role { get; internal set; }
>>>>>>> c3a084b795415919ea2d0ebc20713324eea677b3
    }
}
