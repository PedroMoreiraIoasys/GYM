using GYM_GetYourMuscles.Services.Requests;
using GYM_GetYourMuscles.Services.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GYM_GetYourMuscles.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Task<TokenResponse> Login(LoginRequest loginRequest);
    }
}
