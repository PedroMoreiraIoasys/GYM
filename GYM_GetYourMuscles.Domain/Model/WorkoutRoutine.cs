using System.Collections.Generic;

namespace GYM_GetYourMuscles.Domain.Model
{
    public class WorkoutRoutine : BaseClass
    {
        public WorkoutRoutine()
        {
            WorkoutRoutineExercises = new List<WorkoutRoutineExercise>();
        }

        public string Name { get; set; }
        public IEnumerable<WorkoutRoutineExercise> WorkoutRoutineExercises { set; get; }
        public User User { set; get; }
    }
}