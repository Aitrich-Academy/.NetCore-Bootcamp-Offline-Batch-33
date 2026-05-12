using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Job_Provider.CompanyProfile.DTO
{
    public class CreateCompanyProfileRequest
    {
<<<<<<<< HEAD:Project/JOB PORTAL SYSTEM/JOB PORTAL SYSTEM/Api/Job Provider Module/RequestObjects/CreateCompanyProfileRequest.cs
        
========
>>>>>>>> e0ea4aa4c271825b8415dccd02f64706edbc752c:Project/JOB PORTAL SYSTEM/Domain/Services/Job_Provider/CompanyProfile/DTO/CreateCompanyProfileRequest.cs
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public Guid IndustryId { get; set; }
        public Guid LocationId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }


    }
}
