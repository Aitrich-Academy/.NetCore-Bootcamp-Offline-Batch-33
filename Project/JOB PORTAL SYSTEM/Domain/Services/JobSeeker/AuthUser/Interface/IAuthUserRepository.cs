using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.AuthUser.Interface
{
    public interface IAuthUserRepository
    {
        Task<Models.AuthUser> AddAuthUser(Models.AuthUser authUser);
        Task AddSystemUser(Models.AuthUser user);
        string? CreateToken(Models.AuthUser user);

    }
}
