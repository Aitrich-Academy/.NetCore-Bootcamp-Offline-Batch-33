using AutoMapper;
using Domain.Service.AuthUser.Interface;
using Domain.Service.Login.DTO;
using Domain.Service.Login.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Login
{
    public class LoginRequestServices : ILoginRequestServices
    {
        private readonly ILoginRequestRepository _repository;
        IAuthUserRepository _auth;
        IMapper _mapper;

        public LoginRequestServices(ILoginRequestRepository repository, IAuthUserRepository auth, IMapper mapper)
        {
            _repository = repository;
            _auth = auth;
            _mapper = mapper;
        }
        public LoginrequestDto Login(string email, string password)
        {
            var user = _repository.GetUserByEmailPassword(email, password);
            if (user == null)
            {
                return null;
            }
            var userReturn = _mapper.Map<LoginrequestDto>(user);

            userReturn.Token = _auth.CreateToken(user);
            return userReturn;
        }


        public async Task<string> ForgetPassword(ForgetPasswordDTO dto)
        {
            try
            {
                if (dto.NewPassword != dto.ConfirmPassword)
                    return "Password Does Not Match";

                var user = await _repository.GetUserByEmailAsync(dto.Email);
                if (user == null)
                    return "User not found";

                user.Password = dto.NewPassword;

                await _repository.UpdateUserAsync(user);
                return "Password Updated Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
