using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Job_Provider.AuthUser.Interface
{
    public interface IAuthUserRepository
    {
        Task<Models.AuthUser> AddAuthUser(Models.AuthUser authUser); 

        string? CreateToken(Models.AuthUser user);
    }
}
