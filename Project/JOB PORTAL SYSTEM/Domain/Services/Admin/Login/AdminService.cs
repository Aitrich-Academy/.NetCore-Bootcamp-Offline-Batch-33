using Domain.Models;
using Domain.Services.Admin.Login.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Domain.Services.Admin.Login
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;
        private readonly IConfiguration _configuration;

        public AdminService(
            IAdminRepository adminRepository,
            IConfiguration configuration)
        {
            _adminRepository = adminRepository;
            _configuration = configuration;
        }

        public async Task<string> LoginAsync(
            string email,
            string password)
        {
            try
            {
                var admin = await _adminRepository
                    .LoginAsync(email, password);

                if (admin == null)
                {
                    return "Invalid Credentials";
                }

                return GenerateJwtToken(admin);
            }
            catch (Exception ex)
            {
                return $"Error : {ex.Message}";
            }
        }

        private string GenerateJwtToken(AuthUser user)
        {
            try
            {
                var claims = new[]
                {
                    new Claim(
                        ClaimTypes.Email,
                        user.Email),

                    new Claim(
                        ClaimTypes.Role,
                        user.Role.ToString()),

                    new Claim(
                        "UserId",
                        user.Id.ToString())
                };

                var key = new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(
                        _configuration["Jwt:Key"]));

                var credentials = new SigningCredentials(
                    key,
                    SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: _configuration["Jwt:Issuer"],
                    audience: _configuration["Jwt:Audience"],
                    claims: claims,
                    expires: DateTime.UtcNow.AddMinutes(3),
                    signingCredentials: credentials);

                return new JwtSecurityTokenHandler()
                    .WriteToken(token);
            }
            catch (Exception ex)
            {
                throw new Exception(
                    $"Error while generating token : {ex.Message}");
            }
        }
    }
}