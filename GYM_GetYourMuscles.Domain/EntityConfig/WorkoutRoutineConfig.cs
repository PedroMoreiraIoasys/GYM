using GYM_GetYourMuscles.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GYM_GetYourMuscles.Domain.EntityConfig
{
    public class WorkoutRoutineConfig : IEntityTypeConfiguration<WorkoutRoutine>
    {
        public void Configure(EntityTypeBuilder<WorkoutRoutine> builder)
        {
            builder.HasKey(wr => wr.Id);
            builder.Property(wr => wr.Name).HasColumnType("varchar(100)").IsRequired();
        }
    }
}
