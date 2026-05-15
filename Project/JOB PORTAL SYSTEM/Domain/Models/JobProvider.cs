using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class JobProvider
    {
        public Guid Id { get; set; }

<<<<<<< HEAD
        [ForeignKey("AuthUser")]
        public Guid AuthUserId { get; set; }
        public AuthUser? AuthUser { get; set; }
=======
        [ForeignKey("User")]
        public Guid? UserId { get; set; }
        public AuthUser? User { get; set; }
>>>>>>> c3a084b795415919ea2d0ebc20713324eea677b3

        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Navigation Only(else => Company → JobProvider → Company)
<<<<<<< HEAD
=======

        [ForeignKey("Company")]
        public Guid? CompanyId { get; set; }

>>>>>>> c3a084b795415919ea2d0ebc20713324eea677b3
        public Company? Company { get; set; }
        public CompanyRole CompanyRole { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;


        
      

    }
}
