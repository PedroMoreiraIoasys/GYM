﻿using GYM_GetYourMuscles.Exception;
using GYM_GetYourMuscles.Services.Interfaces;
using GYM_GetYourMuscles.Services.Requests;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GYM_GetYourMuscles.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExerciceController : ControllerBase
    {
        private IUserService _authenticationService;

        public ExerciceController(IUserService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpGet]
        public async Task<ActionResult> GetExercises()
        {
            try
            {
                var token = await _authenticationService.Sign(signRequest);

                return Ok(token);
            }
            catch (BaseException ex)
            {
                return StatusCode(ex._status, ex._error);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Sign(SignRequest signRequest)
        {
            try
            {
                var token = await _authenticationService.Sign(signRequest);
                 
                return Ok(token);
            }
            catch(BaseException ex)
            {
                return StatusCode(ex._status, ex._error);
            }
        }
    }
}
