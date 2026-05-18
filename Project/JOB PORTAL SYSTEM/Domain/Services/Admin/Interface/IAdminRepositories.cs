using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Admin.Interface
{
    public interface IAdminRepositories
    {
        Task<AuthUser> LoginAsync(string email, string password);
    }
}
