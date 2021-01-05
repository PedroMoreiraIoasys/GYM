using GYM_GetYourMuscles.Repositories.Interfaces;
using GYM_GetYourMuscles.Repositories.Repositories;
using GYM_GetYourMuscles.Services.Interfaces;
using GYM_GetYourMuscles.Services.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GYM_GetYourMuscles
{
    public static class DependencyInjection
    {
        public static void RegisterService(IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IUserService, UserService>();
        }

        public static void RegisterRepository(IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
