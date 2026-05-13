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

        [ForeignKey("AuthUser")]
        public Guid AuthUserId { get; set; }
        public AuthUser? AuthUser { get; set; }

        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Navigation Only(else => Company → JobProvider → Company)
        public Company? Company { get; set; }
        public CompanyRole CompanyRole { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;


    }
}
