using Domain.Services.Job_Provider.Login.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Job_Provider.Login.Interface
{
    public interface ILoginRequestService
    {
        JobproviderLoginDto login(string email, string password);
    }
}
