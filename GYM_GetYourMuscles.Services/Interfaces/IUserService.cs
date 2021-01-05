using GYM_GetYourMuscles.Services.Requests;
using GYM_GetYourMuscles.Services.Response;
using System.Threading.Tasks;

namespace GYM_GetYourMuscles.Services.Interfaces
{
    public interface IUserService
    {
        Task<TokenResponse> Sign(SignRequest signRequest);
    }
}
