using GYM_GetYourMuscles.Repositories.Interfaces;
using System.Linq;
using GYM_GetYourMuscles.Domain.Model;

namespace GYM_GetYourMuscles.Repositories.Repositories
{
    public class ExerciseRepository : BaseRepository<Exercise>, IExerciseRepository
    {
        public ExerciseRepository(Context.Context context) : base(context)
        {

        }
    }
}
