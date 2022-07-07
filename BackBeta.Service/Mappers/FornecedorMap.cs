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
    public class FornecedorMap : IEntityTypeConfiguration<FornecedorEntity>
    {
        public void Configure(EntityTypeBuilder<FornecedorEntity> builder)
        {
            builder.ToTable("Fornecedor");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.NomeFantasia)
                  .IsRequired()
                  .HasMaxLength(100);
        }

    }
}
