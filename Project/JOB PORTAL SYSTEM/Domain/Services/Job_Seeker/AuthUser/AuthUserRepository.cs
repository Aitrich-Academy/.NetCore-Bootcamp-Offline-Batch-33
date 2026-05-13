using AutoMapper;
using Domain.Data;
using Domain.Enums;
using Domain.Models;
using Domain.Services.Job_Seeker.AuthUser.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Job_Seeker.AuthUser
{
    public class AuthUserRepository : IAuthUserRepository
    {
        private readonly AppDbContext _context;
        IMapper _mapper;
        private readonly IConfiguration _configuration;

        public AuthUserRepository(AppDbContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }
        public async Task<Models.AuthUser> AddAuthUser(Models.AuthUser authuser)
        {
            authuser.Role = Role.JobSeeker;

            await _context.AuthUsers.AddAsync(authuser);
            await _context.SaveChangesAsync();

            return authuser;
        }
        public async Task AddSystemUser( Models.AuthUser user)
        {
            await _context.AuthUsers.AddAsync(user);
            await _context.SaveChangesAsync();
        }
        public string? CreateToken(Models.AuthUser user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user), "User Object Cannot be null");
            }
            string tokenSecret = _configuration.GetSection("AuthSettings:Token").Value;
            if (string.IsNullOrEmpty(tokenSecret))
            {
                throw new InvalidOperationException("Token secret is missing or empty in configuration.");
            }

            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.FirstName),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Sid, user.Id.ToString()),
                new Claim(ClaimTypes.Role, user.Role.ToString())
            };
            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                _configuration.GetSection("AuthSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
    }
}
