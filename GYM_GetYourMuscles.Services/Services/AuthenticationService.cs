using GYM_GetYourMuscles.Domain.Model;
using GYM_GetYourMuscles.Exception;
using GYM_GetYourMuscles.Repositories.Interfaces;
using GYM_GetYourMuscles.Services.Interfaces;
using GYM_GetYourMuscles.Services.Requests;
using GYM_GetYourMuscles.Services.Response;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GYM_GetYourMuscles.Services.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private IUserRepository _userRepository;
        public AuthenticationService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<TokenResponse> Login(LoginRequest loginRequest)
        {
            var user = _userRepository.GetByEmail(loginRequest.Email);
            if (user != null && loginRequest.Password != null && PasswordService.PasswordIsCorrect(user.Password.Split(".")[1], user.Password.Split(".")[2], loginRequest.Password))
            {
                return Task.FromResult(new TokenResponse { Token = JwtService.GetToken(user) });
            }
            else
            {
                throw new UnauthorizedException("Credenciais incorretas");
            }
        }
    }
}
