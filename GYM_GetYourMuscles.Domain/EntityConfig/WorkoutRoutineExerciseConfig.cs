using GYM_GetYourMuscles.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GYM_GetYourMuscles.Domain.EntityConfig
{
    public class WorkoutRoutineExerciseConfig : IEntityTypeConfiguration<WorkoutRoutineExercise>
    {
        public void Configure(EntityTypeBuilder<WorkoutRoutineExercise> builder)
        {
            builder.HasKey(wre => new { wre.ExerciseId, wre.WorkoutRoutineId });

            builder.HasOne(wre => wre.Exercise).WithMany(e => e.WorkoutRoutineExercises).HasForeignKey(wre => wre.ExerciseId);
            builder.HasOne(wre => wre.WorkoutRoutine).WithMany(wr => wr.WorkoutRoutineExercises).HasForeignKey(wre => wre.WorkoutRoutineId);
        }
    }
}
