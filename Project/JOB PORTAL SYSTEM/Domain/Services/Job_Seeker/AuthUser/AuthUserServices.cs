//using Domain.Service.AuthUser.Interface;
//using Microsoft.AspNetCore.Http;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Claims;
//using System.Text;
//using System.Threading.Tasks;

//namespace Domain.Service.AuthUser
//{
//    public class AuthUserServices : IAuthUserServices
//    {
//        private readonly IHttpContextAccessor _httpContextAccessor;
//        private readonly IAuthUserRepository _userRepository;

//        public AuthUserServices(IHttpContextAccessor httpContextAccessor, IAuthUserRepository userRepository)
//        {
//            _httpContextAccessor = httpContextAccessor;
//            _userRepository = userRepository;
//        }

//        public string GetUserId()
//        {
//            var claim = _httpContextAccessor.HttpContext?
//         .User?
//         .FindFirst(ClaimTypes.NameIdentifier);

//            return claim?.Value;
//        }
//    }
//}
