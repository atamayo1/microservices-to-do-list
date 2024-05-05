using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Authentication.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Authentication.Services
{
    public interface IAuthenticationService
    {
        Task<string> Authenticate(string username, string password);
        Task<string> Register(string username, string password, string email);
    }

    public class AuthenticationService : IAuthenticationService
    {
        private readonly IConfiguration _configuration;

        public AuthenticationService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<string> Authenticate(string username, string password)
        {
            // Aquí iría la lógica de autenticación real, como verificar las credenciales en la base de datos
            if (username == "usuario" && password == "clave")
            {
                // Si las credenciales son válidas, se genera un token JWT
                return GenerateJwtToken(username);
            }
            else
            {
                // Si las credenciales no son válidas, se lanza una excepción
                throw new UnauthorizedAccessException("Credenciales inválidas");
            }
        }

        public async Task<string> Register(string username, string password, string email)
        {
            // Aquí iría la lógica para registrar el usuario en la base de datos
            // Por simplicidad, en este ejemplo simplemente se autentica al usuario
            return await Authenticate(username, password);
        }

        private string GenerateJwtToken(string username)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:Secret"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["JwtSettings:Issuer"],
                audience: _configuration["JwtSettings:Audience"],
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
