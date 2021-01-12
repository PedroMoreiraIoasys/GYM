using GYM_GetYourMuscles.Repositories.Interfaces;
using GYM_GetYourMuscles.Services.Interfaces;
using GYM_GetYourMuscles.Services.Requests;
using GYM_GetYourMuscles.Services.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GYM_GetYourMuscles.Services.Services
{
    public class ExerciseService : IExerciseService
    {
        private IExerciseRepository _exerciseRepository;
        public ExerciseService(IExerciseRepository exerciseRepository)
        {
            _exerciseRepository = exerciseRepository;
        }

        public async void DeleteExercise(long id)
        {
            await _exerciseRepository.Delete(id);
        }

        public async Task<IEnumerable<ExerciseResponse>> GetExercises()
        {
            var exercises = await _exerciseRepository.GetAll();

            var response = exercises.ConvertAll(x => new ExerciseResponse { Id = x.Id, CreatedAt = x.CreatedAt, Type = x.Type, Name = x.Name, });

            return response;
        }

        public Task<ExerciseResponse> InsertExercise(ExerciseRequest signRequest)
        {
            throw new NotImplementedException();
        }

        public Task<ExerciseResponse> UpdateExercise(ExerciseRequest signRequest)
        {
            throw new NotImplementedException();
        }
    }
}
