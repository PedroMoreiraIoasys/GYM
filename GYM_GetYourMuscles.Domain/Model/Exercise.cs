using System.Collections.Generic;

namespace GYM_GetYourMuscles.Domain.Model
{
    public class Exercise : BaseClass
    {
        public Exercise()
        {
            WorkoutRoutineExercises = new List<WorkoutRoutineExercise>();
        }
        public string Name { get; set; }
        public string Type { get; set; }
        public IEnumerable<WorkoutRoutineExercise> WorkoutRoutineExercises { get; set; }
    }
}
