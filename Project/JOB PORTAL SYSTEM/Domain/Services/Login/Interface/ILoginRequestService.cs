using Domain.Services.Login.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Login.Interface
{
    public interface ILoginRequestService
    {
        JobproviderLoginDto login(string email, string password);
    }
}
