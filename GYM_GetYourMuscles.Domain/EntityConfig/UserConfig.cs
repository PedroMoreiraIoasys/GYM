using GYM_GetYourMuscles.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GYM_GetYourMuscles.Domain.EntityConfig
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.HasIndex(u => u.Email).IsUnique();

            builder.HasMany(c => c.Training).WithOne(c => c.User).IsRequired();

            builder.Property(u => u.Email).HasColumnType("varchar(100)").IsRequired();
            builder.Property(u => u.Name).HasColumnType("varchar(100)").IsRequired();
            builder.Property(u => u.Role).HasColumnType("varchar(20)").IsRequired();
            builder.Property(u => u.Height).HasColumnType("varchar(10)").IsRequired();
            builder.Property(u => u.Birthday).IsRequired();
        }
    }
}
