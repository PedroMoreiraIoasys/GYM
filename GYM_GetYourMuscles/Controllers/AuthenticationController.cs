using GYM_GetYourMuscles.Exception;
using GYM_GetYourMuscles.Services.Interfaces;
using GYM_GetYourMuscles.Services.Requests;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GYM_GetYourMuscles.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost]
        
        public async Task<ActionResult> Login(LoginRequest loginRequest)
        {
            try
            {
                var token = await _authenticationService.Login(loginRequest);
                 
                return Ok(token);
            }
            catch(BaseException ex)
            {
                return StatusCode(ex._status, ex._error);
            }
        }
    }
}
