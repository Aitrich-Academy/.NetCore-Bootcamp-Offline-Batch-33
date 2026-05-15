using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Admin.Login.Interface
{
    public interface IAdminRepository
    {
        Task<AuthUser> LoginAsync(string email, string password);
    }
}
