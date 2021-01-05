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
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<TokenResponse> Sign(SignRequest signRequest)
        {
            var user = _userRepository.GetByEmail(signRequest.Email);
            if (user != null)
                throw new UnprocessableException("Email ja cadastrado");

            user = new User
            {
                Email = signRequest.Email,
                Name = signRequest.Name,
                Birthday = signRequest.Birthday,
                Height = signRequest.Height,
                Password = PasswordService.GeneratePassword(signRequest.Password),
                CreatedAt = DateTime.UtcNow,
                Role = "user"
            };

            _userRepository.Insert(user);
            return Task.FromResult(new TokenResponse { Token = JwtService.GetToken(user) });
        }
    }
}
