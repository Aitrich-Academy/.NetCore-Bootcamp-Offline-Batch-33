using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Login.Interface
{
    public interface ILoginRequestRepository
    {
        Models.AuthUser GetUserByEmail(string email);

        Models.AuthUser GetUserByEmailPassword(string email, string password);
        Task<Models.AuthUser> GetUserByEmailAsync(string email);
        Task UpdateUserAsync(Models.AuthUser user);
    }
}
