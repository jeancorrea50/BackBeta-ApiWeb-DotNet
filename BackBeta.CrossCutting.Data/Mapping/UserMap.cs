using BackBeta.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBeta.CrossCutting.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {   
              // Nome Tabela
            builder.ToTable("User");

             // Chave da tabela 
            builder.HasKey(u => u.Id);

            // Name Obrigatorio  e 
            builder.Property(u => u.Name)
                  .IsRequired()
                  .HasMaxLength(80);

            // E-mail Unico
            builder.HasIndex(p => p.Email)
                 .IsUnique();

            // Maximo caracteres
            builder.Property(u => u.Email)
                    .HasMaxLength(100);

        }
    }

}
