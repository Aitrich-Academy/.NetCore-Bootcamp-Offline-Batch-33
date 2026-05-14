using Domain.Services.Auth.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Auth.Interface
{
    public interface IAuthService
    {
        Task<Guid> Signup(SignupRequestDTO dto);

        Task<bool> VerifyEmail(Guid signupId);

        Task<string> SetPassword(Guid signupId, PasswordDTO dto);

        Task<LoginDTO> Login(LoginRequestDTO dto);

        Task<string> ForgetPassword(ForgetPasswordDTO dto);
    }
}
