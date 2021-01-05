using GYM_GetYourMuscles.Services.Requests;
using GYM_GetYourMuscles.Services.Response;
using GYM_GetYourMuscles.Services.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GYM_GetYourMuscles.Services.Interfaces
{
    public interface IExerciseService
    {
        Task<IEnumerable<ExerciseResponse>> GetExercise();
        Task<ExerciseResponse> InsertExercise(ExerciseRequest signRequest);
        Task<ExerciseResponse> UpdateExercise(ExerciseRequest signRequest);
        void DeleteExercise(long id);
    }
}
