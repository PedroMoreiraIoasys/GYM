using GYM_GetYourMuscles.Domain.EntityConfig;
using GYM_GetYourMuscles.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace GYM_GetYourMuscles.Repositories.Context
{
    public partial class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<WorkoutRoutine> WorkoutRoutines { get; set; }

        public Context()
        {
        }
        public Context(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new ExerciseConfig());
            modelBuilder.ApplyConfiguration(new WorkoutRoutineConfig());
            modelBuilder.ApplyConfiguration(new WorkoutRoutineExerciseConfig());
        }

    }
}
