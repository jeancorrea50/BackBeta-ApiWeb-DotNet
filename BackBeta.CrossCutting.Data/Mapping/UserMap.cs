using BackBeta.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBeta.Infrastructure.CrossCutting.Mapping
{
    public class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("User");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Email)
                  .IsRequired()
                  .HasMaxLength(100);

            builder.HasIndex(u => u.Email)
                  .IsUnique();

            builder.Property(u => u.Name)
                   .IsRequired()
                   .HasMaxLength(100);
        }
    }
}
