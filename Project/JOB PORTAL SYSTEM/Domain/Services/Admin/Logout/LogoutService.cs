using Domain.Services.Admin.Logout.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Admin.Logout
{
    public class LogoutService : ILogoutService
    {
        private readonly ILogoutRepository _logoutRepository;

        public LogoutService(ILogoutRepository logoutRepository)
        {
            _logoutRepository = logoutRepository;
        }

        public async Task<string>LogoutAsync()
        {
            await _logoutRepository.LogoutAsync();

            return "Logout Successful";
        }
    }
}