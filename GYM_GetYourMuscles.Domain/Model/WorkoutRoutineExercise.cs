namespace GYM_GetYourMuscles.Domain.Model
{
    public class WorkoutRoutineExercise
    {
        public int Weight { get; set; } = 0;
        public long ExerciseId { set; get; }
        public Exercise Exercise { set; get; }
        public long WorkoutRoutineId { set; get; }
        public WorkoutRoutine WorkoutRoutine { set; get; }
    }
}