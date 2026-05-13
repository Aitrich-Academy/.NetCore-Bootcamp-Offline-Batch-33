using Domain.Data;
using Domain.Services.Job_Provider.Login.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Job_Provider.Login
{
    public class LoginRequestRepository : ILoginRequestRepository
    {
        private readonly AppDbContext _context;

        public LoginRequestRepository(AppDbContext context)
        {
            _context = context;
        }
        public Models.AuthUser GetUserByEmail(string email)
        {
            var user = _context.AuthUsers.FirstOrDefault(x => x.Email == email);
            return user;
        }
        public Models.AuthUser GetUserByEmailpassword(string email, string password)
        {
            var user = _context.AuthUsers.FirstOrDefault(e => e.Email == email && e.Password == password);
            return user;
        }
    
    }
}
