using GYM_GetYourMuscles.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GYM_GetYourMuscles.Domain.EntityConfig
{
    public class ExerciseConfig : IEntityTypeConfiguration<Exercise>
    {
        public void Configure(EntityTypeBuilder<Exercise> builder)
        {
            builder.HasKey(wr => wr.Id);

            builder.Property(wr => wr.Name).HasColumnType("varchar(100)").IsRequired();
            builder.Property(wr => wr.Type).HasColumnType("varchar(50)").IsRequired();
        }
    }
}
