using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Admin.Interface
{
    public interface IAdminServices
    {
        Task<string> LoginAsync(string email, string password);
    }
}
