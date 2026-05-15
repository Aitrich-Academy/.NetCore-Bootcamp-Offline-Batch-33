using Domain.Services.Admin.Logout.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Admin.Logout
{
    public class LogoutRepository : ILogoutRepository
    {
        public async Task LogoutAsync()
        {
            await Task.CompletedTask;
        }
    }
}
