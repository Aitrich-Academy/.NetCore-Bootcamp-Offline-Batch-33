using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Admin.Login.Interface
{
    public interface IAdminService
    {
        Task<string> LoginAsync(string email, string password);
    }
}
