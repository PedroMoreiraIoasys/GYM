using GYM_GetYourMuscles.Exception;
using GYM_GetYourMuscles.Services.Interfaces;
using GYM_GetYourMuscles.Services.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using System.Threading.Tasks;

namespace GYM_GetYourMuscles.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExerciceController : ControllerBase
    {
        private IExerciseService _exerciseService;

        public ExerciceController(IExerciseService exerciseService)
        {
            _exerciseService = exerciseService;
        }

        [Authorize]
        [HttpGet]
        public async Task<ActionResult> GetExercises()
        {
            try
            {
                var email = JwtService.GetEmailFromToken(Request.Headers[HeaderNames.Authorization]);
                var exercises = await _exerciseService.GetExercises();

                return Ok(exercises);
            }
            catch (BaseException ex)
            {
                return StatusCode(ex._status, ex._error);
            }
        }
    }
}
