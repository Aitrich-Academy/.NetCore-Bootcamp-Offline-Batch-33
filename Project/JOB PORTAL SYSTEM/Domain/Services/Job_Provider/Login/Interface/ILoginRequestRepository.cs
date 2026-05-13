using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Job_Provider.Login.Interface
{
    public interface ILoginRequestRepository
    {
        Models.AuthUser GetUserByEmail(string email);
        Models.AuthUser GetUserByEmailpassword(string email, string password);
    }
}
